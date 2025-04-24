using System;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace GloboTicket.TicketManagement.Application.Features.ProfilesUsers.Queries.GetUserPic
{
    public class GetUserPicDto : IRequest<GetUserPicQueryVm>
    {
        public Guid Id { get; set; }
        public IFormFile PicUser { get; set; }
    }
}