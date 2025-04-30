using System.Collections.Generic;
using MediatR;

namespace GloboTicket.TicketManagement.Application.Features.Roles.Queries.GetRolesList
{
    public class GetRolesListQuery: IRequest<List<GetRolesListVm>>
    {
        
    }
}