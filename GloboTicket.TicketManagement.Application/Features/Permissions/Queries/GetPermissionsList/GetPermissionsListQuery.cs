using System.Collections.Generic;
using MediatR;

namespace GloboTicket.TicketManagement.Application.Features.Permissions.Queries.GetPermissionsList
{
    public class GetPermissionsListQuery: IRequest<List<GetPermissionsListVm>>
    {
        
    }
}