using System.Collections.Generic;
using System.Threading.Tasks;
using GloboTicket.TicketManagement.Application.Contracts.Persistence;
using GloboTicket.TicketManagement.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace GloboTicket.TicketManagement.Persistence.Repositories
{
    public class PermissionRepository: BaseRepository<Permission>, IPermissionRepository
    {
        public PermissionRepository(GloboTicketDbContext dbContext) : base(dbContext)
        {
        }
        
        public async Task<List<Permission>> GetPermissions()
        {
            return await _dbContext.Permissions.ToListAsync();
          
        }
    }
}