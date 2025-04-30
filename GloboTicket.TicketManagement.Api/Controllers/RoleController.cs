using System.Collections.Generic;
using System.Threading.Tasks;
using GloboTicket.TicketManagement.Application.Features.Roles.Commands.Create;
using GloboTicket.TicketManagement.Application.Features.Roles.Queries.GetRolesList;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GloboTicket.TicketManagement.Api.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class RoleController: ControllerBase
    {
        private readonly IMediator _mediator;
        
        public RoleController(IMediator mediator)
        {
            _mediator = mediator;
        }
        
        // Investigar esto, Task<ActionResult.. 
        [HttpPost(Name = "AddRole")]
        public async Task<ActionResult<CreateRoleCommandResponse>> Create(
            [FromForm] CreateRoleCommand command)
        {
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        [HttpGet("all", Name = "GetAllRoles")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<GetRolesListVm>>> GetAllRoles()
        {
            var dtos = await _mediator.Send(new GetRolesListQuery());
            return Ok(dtos);
        }
        
        
    }
    
    
}