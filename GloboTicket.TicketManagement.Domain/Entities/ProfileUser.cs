using System;
using GloboTicket.TicketManagement.Domain.Common;

namespace GloboTicket.TicketManagement.Domain.Entities
{
    public class ProfileUser : AuditableEntity
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public byte[] PicUser { get; set; }
    }
}