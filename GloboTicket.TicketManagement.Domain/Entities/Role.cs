using System;
using System.Collections.Generic;
using GloboTicket.TicketManagement.Domain.Common;

namespace GloboTicket.TicketManagement.Domain.Entities
{
    public class Role: AuditableEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        //public ICollection<Permission> Permissions { get; set; }
    }
}