using System.Collections.Generic;
using System.Threading.Tasks;
using GloboTicket.TicketManagement.Domain.Entities;

namespace GloboTicket.TicketManagement.Application.Contracts.Persistence
{
    public interface IRoleRepository: IAsyncRepository<Role>
    {
        Task<List<Role>> GetRoles();
    
    }
}