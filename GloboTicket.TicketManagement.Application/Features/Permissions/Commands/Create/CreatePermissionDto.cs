using System;

namespace GloboTicket.TicketManagement.Application.Features.Permissions.Commands.Create
{
    public class CreatePermissionDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}