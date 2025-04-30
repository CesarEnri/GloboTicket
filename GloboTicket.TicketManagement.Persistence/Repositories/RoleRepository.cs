using System.Collections.Generic;
using System.Threading.Tasks;
using GloboTicket.TicketManagement.Application.Contracts.Persistence;
using GloboTicket.TicketManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace GloboTicket.TicketManagement.Persistence.Repositories
{
    public class RoleRepository: BaseRepository<Role>, IRoleRepository
    {
        public RoleRepository(GloboTicketDbContext dbContext) : base(dbContext)
        {
        }
        
        public async Task<List<Role>> GetRoles()
        {
            return await _dbContext.Roles.ToListAsync();
          
        }
    }
}