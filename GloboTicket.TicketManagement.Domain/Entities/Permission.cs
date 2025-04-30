using System;
using GloboTicket.TicketManagement.Domain.Common;

namespace GloboTicket.TicketManagement.Domain.Entities
{
    public class Permission: AuditableEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        //public Guid RoleId { get; set; }
        //public Role Role { get; set; }
    }
} 