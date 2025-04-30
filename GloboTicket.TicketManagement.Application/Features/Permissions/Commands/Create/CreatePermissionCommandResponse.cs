using GloboTicket.TicketManagement.Application.Response;

namespace GloboTicket.TicketManagement.Application.Features.Permissions.Commands.Create
{
    public class CreatePermissionCommandResponse: BaseResponse
    {
        public CreatePermissionDto Permission { get; set; }
    }
}