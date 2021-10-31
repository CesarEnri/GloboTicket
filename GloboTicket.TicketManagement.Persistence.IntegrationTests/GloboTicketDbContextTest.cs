using System;
using Microsoft.EntityFrameworkCore;
using Moq;

namespace GloboTicket.TicketManagement.Persistence.IntegrationTests
{
    public class GloboTicketDbContextTest
    {
        private readonly GloboTicketDbContextTest _globoTicketDbContext;
        //private readonly Mock<ILoggedInUserService> _loggedInUserServiceMock;
        private readonly string _loggedInUserId;

        public GloboTicketDbContextTest()
        {
           // var dbContextOptions =
               // new DbContextOptionsBuilder<GloboTicketDbContext>().UseInMemoryDatabase(Guid.NewGuid().ToString());
            
        }
    }
}