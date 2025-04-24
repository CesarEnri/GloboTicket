using GloboTicket.TicketManagement.Application.Response;

namespace GloboTicket.TicketManagement.Application.Features.ProfilesUsers.Commands.Create
{
    public class CreateProfileUserCommandResponse : BaseResponse
    {
        public CreateProfileUserDto ProfileUser { get; set; }
    }
}