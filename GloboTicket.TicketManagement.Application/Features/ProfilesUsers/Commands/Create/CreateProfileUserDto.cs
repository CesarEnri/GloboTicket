using System;

namespace GloboTicket.TicketManagement.Application.Features.ProfilesUsers.Commands.Create
{
    public class CreateProfileUserDto
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
}