using System;

namespace GloboTicket.TicketManagement.Application.Features.Roles.Commands.Create
{
    public class CreateRoleDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}