using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using GloboTicket.TicketManagement.Application.Contracts.Persistence;
using GloboTicket.TicketManagement.Domain.Entities;
using MediatR;

namespace GloboTicket.TicketManagement.Application.Features.Permissions.Queries.GetPermissionsList
{
    public class GetPermissionsListHandler: IRequestHandler<GetPermissionsListQuery, List<GetPermissionsListVm>>
    {
            private readonly IAsyncRepository<Permission> _permissionRepository;
            private readonly IMapper _mapper;

            public GetPermissionsListHandler(IMapper mapper, IAsyncRepository<Permission> permissionRepository)
            {
                _mapper = mapper;
                _permissionRepository = permissionRepository;
            }
        
            public async Task<List<GetPermissionsListVm>> Handle(GetPermissionsListQuery request, CancellationToken cancellationToken)
            {
                var allRoles = (await _permissionRepository.ListAllAsync()).OrderBy(x => x.Name);
                return _mapper.Map<List<GetPermissionsListVm>>(allRoles);
            }
    }
}
