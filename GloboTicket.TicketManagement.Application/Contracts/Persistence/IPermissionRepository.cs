using System.Collections.Generic;
using System.Threading.Tasks;
using GloboTicket.TicketManagement.Domain.Entities;

namespace GloboTicket.TicketManagement.Application.Contracts.Persistence
{
    public interface IPermissionRepository: IAsyncRepository<Permission>
    {
        Task<List<Permission>> GetPermissions();


    }
}