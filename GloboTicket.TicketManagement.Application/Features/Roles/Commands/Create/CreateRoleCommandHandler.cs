
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using GloboTicket.TicketManagement.Application.Contracts.Persistence;
using GloboTicket.TicketManagement.Domain.Entities;
using MediatR;

namespace GloboTicket.TicketManagement.Application.Features.Roles.Commands.Create
{
    public class CreateRoleCommandHandler: IRequestHandler<CreateRoleCommand, CreateRoleCommandResponse>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<Role> _roleRepository;

        public CreateRoleCommandHandler(IMapper mapper, IAsyncRepository<Role> roleRepository)
        {
            _mapper = mapper;
            _roleRepository = roleRepository;
        }
        
        public async Task<CreateRoleCommandResponse> Handle(CreateRoleCommand request, CancellationToken cancellationToken)
        {
            var createRoleCommand = new CreateRoleCommandResponse();

            var validator = new CreateRoleCommandValidator();
            var validationResult = await validator.ValidateAsync(request, cancellationToken);

            if (validationResult.Errors.Count > 0)
            {
                createRoleCommand.Success = false;
                createRoleCommand.ValidationErrors = new List<string>();
                foreach (var error in validationResult.Errors)
                    createRoleCommand.ValidationErrors.Add(error.ErrorMessage);
            }

            if (createRoleCommand.Success)
            {

                var role = new Role
                {
                    Name = request.Name,
                    Description = request.Description
                };
                role = await _roleRepository.AddAsync(role);
                createRoleCommand.Role = _mapper.Map<CreateRoleDto>(role);
            }

            return createRoleCommand;

        }
    }
}