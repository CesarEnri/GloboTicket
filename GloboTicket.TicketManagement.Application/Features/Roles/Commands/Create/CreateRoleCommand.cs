using MediatR;

namespace GloboTicket.TicketManagement.Application.Features.Roles.Commands.Create
{
    public class CreateRoleCommand: IRequest<CreateRoleCommandResponse>
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}