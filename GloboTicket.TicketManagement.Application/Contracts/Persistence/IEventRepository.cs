﻿using System;
using System.Threading.Tasks;
using GloboTicket.TicketManagement.Domain.Entities;

namespace GloboTicket.TicketManagement.Application.Contracts.Persistence
{
    public interface IEventRepository : IAsyncRepository<Event>
    {
        Task<bool> IsEventNameAndDAteUnique(string name, DateTime eventDate);
    }
}