using System.IO;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using GloboTicket.TicketManagement.Application.Contracts.Persistence;
using GloboTicket.TicketManagement.Domain.Entities;
using GloboTicket.TicketManagement.Infrastructure.Excel;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace GloboTicket.TicketManagement.Application.Features.ProfilesUsers.Queries.GetUserPic
{
    public class GetUserPicQueryHandler : IRequestHandler<GetUserPicQuery, GetUserPicQueryVm>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<ProfileUser> _repository;

        public GetUserPicQueryHandler(IMapper mapper, IAsyncRepository<ProfileUser> repository,
            ICsvExporter csvExporter)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<GetUserPicQueryVm> Handle(GetUserPicQuery request, CancellationToken cancellationToken)
        {
            var data = _mapper.Map<ProfileUser>(await _repository.GetByIdAsync(request.Id));
            var convertDto = new GetUserPicDto();
            var finalResult = new GetUserPicQueryVm();
            if (data == null)
            {
                finalResult.UserPicDto = convertDto;
                return finalResult;
            }

            convertDto.PicUser = ConvertByteArrayToIFormFile(data.PicUser, data.FirstName);
            convertDto.Id = data.Id;

            finalResult.UserPicDto = convertDto;

            return finalResult;
        }

        private static IFormFile ConvertByteArrayToIFormFile(byte[] fileBytes, string fileName)
        {
            var stream = new MemoryStream(fileBytes);
            return new FormFile(stream, 0, fileBytes.Length, "file", fileName)
            {
                Headers = new HeaderDictionary(),
                ContentType = "image/jpeg"
            };
        }
    }
}