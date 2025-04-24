using System;
using MediatR;

namespace GloboTicket.TicketManagement.Application.Features.ProfilesUsers.Queries.GetUserPic
{
    public class GetUserPicQuery : IRequest<GetUserPicQueryVm>
    {
        public Guid Id { get; set; }
    }
}