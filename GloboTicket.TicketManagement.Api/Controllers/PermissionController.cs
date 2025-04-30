using System.Collections.Generic;
using System.Threading.Tasks;
using GloboTicket.TicketManagement.Application.Features.Permissions.Commands.Create;
using GloboTicket.TicketManagement.Application.Features.Permissions.Queries.GetPermissionsList;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GloboTicket.TicketManagement.Api.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class PermissionController: ControllerBase
    {
        private readonly IMediator _mediator;

        public PermissionController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost(Name = "AddPermission")]
        public async Task<ActionResult<CreatePermissionCommandResponse>> Create(
            [FromForm] CreatePermissionCommand command)
        {
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        [HttpGet("all", Name = "GetAllPermissions")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<GetPermissionsListVm>>> GetAllPermissions()
        {
            var dtos = await _mediator.Send(new GetPermissionsListQuery());
            return Ok(dtos);
        }
    }
}