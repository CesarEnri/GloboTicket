using GloboTicket.TicketManagement.Application.Response;

namespace GloboTicket.TicketManagement.Application.Features.Roles.Commands.Create
{
    public class CreateRoleCommandResponse: BaseResponse
    {
        public CreateRoleDto Role { get; set; }
    }
}