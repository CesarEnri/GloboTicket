using System;
using System.Threading.Tasks;
using GloboTicket.TicketManagement.Application.Features.ProfilesUsers.Commands.Create;
using GloboTicket.TicketManagement.Application.Features.ProfilesUsers.Queries.GetUserPic;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace GloboTicket.TicketManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfileUserController : ControllerBase
    {
        private readonly IMediator _mediator;


        public ProfileUserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost(Name = "AddProfileUser")]
        public async Task<ActionResult<CreateProfileUserCommandResponse>> Create(
            [FromForm] CreateProfileUserCommand command)
        {
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        [HttpGet("{id}", Name = "GetPicUser")]
        public async Task<ActionResult<GetUserPicQueryVm>> GetPicUserById(Guid id)
        {
            var result = await _mediator.Send(new GetUserPicQuery { Id = id });

            var file = result.UserPicDto.PicUser;
            if (file == null) return NotFound("Imagen no encontrada");

            return File(
                file.OpenReadStream(),
                file.ContentType,
                file.FileName
            );
        }
    }
}