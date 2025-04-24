using System.Collections.Generic;
using System.Threading.Tasks;
using GloboTicket.TicketManagement.Application.Contracts.Persistence;
using GloboTicket.TicketManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace GloboTicket.TicketManagement.Persistence.Repositories
{
    public class ProfileUserRepository : BaseRepository<ProfileUser>, IProfileUserRepository
    {
        public ProfileUserRepository(GloboTicketDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<List<ProfileUser>> GetProfileUsers()
        {
            return await _dbContext.ProfileUsers.ToListAsync();
        }
    }
}