using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using GloboTicket.TicketManagement.Application.Contracts.Persistence;
using GloboTicket.TicketManagement.Domain.Entities;
using MediatR;

namespace GloboTicket.TicketManagement.Application.Features.Roles.Queries.GetRolesList
{
    public class GetRolesListHandler : IRequestHandler<GetRolesListQuery, List<GetRolesListVm>>
    {
        private readonly IAsyncRepository<Role> _roleRepository;
        private readonly IMapper _mapper;

        public GetRolesListHandler(IMapper mapper, IAsyncRepository<Role> roleRepository)
        {
            _mapper = mapper;
            _roleRepository = roleRepository;
        }
        
        public async Task<List<GetRolesListVm>> Handle(GetRolesListQuery request, CancellationToken cancellationToken)
        {
            var allRoles = (await _roleRepository.ListAllAsync()).OrderBy(x => x.Name);
            return _mapper.Map<List<GetRolesListVm>>(allRoles);
        }
    }
}