using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using GloboTicket.TicketManagement.Application.Contracts.Persistence;
using GloboTicket.TicketManagement.Domain.Entities;
using MediatR;

namespace GloboTicket.TicketManagement.Application.Features.ProfilesUsers.Commands.Create
{
    public class
        CreateProfileUserCommandHandler : IRequestHandler<CreateProfileUserCommand, CreateProfileUserCommandResponse>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<ProfileUser> _profileUserRepository;

        public CreateProfileUserCommandHandler(IMapper mapper, IAsyncRepository<ProfileUser> profileUserRepository)
        {
            _mapper = mapper;
            _profileUserRepository = profileUserRepository;
        }

        public async Task<CreateProfileUserCommandResponse> Handle(CreateProfileUserCommand request,
            CancellationToken cancellationToken)
        {
            var createProfileUserCommand = new CreateProfileUserCommandResponse();

            var validator = new CreateProfileUserCommandValidator();
            var validationResult = await validator.ValidateAsync(request, cancellationToken);

            if (validationResult.Errors.Count > 0)
            {
                createProfileUserCommand.Success = false;
                createProfileUserCommand.ValidationErrors = new List<string>();
                foreach (var error in validationResult.Errors)
                    createProfileUserCommand.ValidationErrors.Add(error.ErrorMessage);
            }

            if (createProfileUserCommand.Success)
            {
                var dataImage = Array.Empty<byte>();
                if (request.PicUser != null)
                {
                    using var memoryStream = new MemoryStream();
                    await request.PicUser.CopyToAsync(memoryStream, cancellationToken);
                    dataImage = memoryStream.ToArray();
                }

                var profile = new ProfileUser
                {
                    FirstName = request.FirstName,
                    LastName = request.LastName,
                    Age = request.Age,
                    PicUser = dataImage
                };
                profile = await _profileUserRepository.AddAsync(profile);
                createProfileUserCommand.ProfileUser = _mapper.Map<CreateProfileUserDto>(profile);
            }

            return createProfileUserCommand;
        }
    }
}