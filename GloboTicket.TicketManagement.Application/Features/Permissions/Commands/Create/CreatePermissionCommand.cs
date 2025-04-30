using GloboTicket.TicketManagement.Application.Features.Roles.Commands.Create;
using MediatR;

namespace GloboTicket.TicketManagement.Application.Features.Permissions.Commands.Create
{
    public class CreatePermissionCommand: IRequest<CreatePermissionCommandResponse>
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}