using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using GloboTicket.TicketManagement.Application.Contracts.Persistence;
using GloboTicket.TicketManagement.Domain.Entities;
using MediatR;

namespace GloboTicket.TicketManagement.Application.Features.Permissions.Commands.Create
{
    public class CreatePermissionCommandHandler: IRequestHandler<CreatePermissionCommand, CreatePermissionCommandResponse>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<Permission> _permissionRepository;

        public CreatePermissionCommandHandler(IMapper mapper, IAsyncRepository<Permission> permissionRepository)
        {
            _mapper = mapper;
            _permissionRepository = permissionRepository;
        }
        
        public async Task<CreatePermissionCommandResponse> Handle(CreatePermissionCommand request, CancellationToken cancellationToken)
        {
            var createPermissionCommand = new CreatePermissionCommandResponse();

            var validator = new CreatePermissionCommandValidator();
            var validationResult = await validator.ValidateAsync(request, cancellationToken);

            if (validationResult.Errors.Count > 0)
            {
                createPermissionCommand.Success = false;
                createPermissionCommand.ValidationErrors = new List<string>();
                foreach (var error in validationResult.Errors)
                    createPermissionCommand.ValidationErrors.Add(error.ErrorMessage);
            }

            if (createPermissionCommand.Success)
            {

                var permission = new Permission
                {
                    Name = request.Name,
                    Description = request.Description
                };
                permission = await _permissionRepository.AddAsync(permission);
                createPermissionCommand.Permission = _mapper.Map<CreatePermissionDto>(permission);
            }

            return createPermissionCommand;

        }
    }
}