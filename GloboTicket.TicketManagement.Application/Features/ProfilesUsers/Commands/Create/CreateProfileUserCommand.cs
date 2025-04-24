using MediatR;
using Microsoft.AspNetCore.Http;

// Asegúrate de incluir esta referencia

namespace GloboTicket.TicketManagement.Application.Features.ProfilesUsers.Commands.Create
{
    public class CreateProfileUserCommand : IRequest<CreateProfileUserCommandResponse>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        //File Data.
        public IFormFile PicUser { get; set; }
    }
}