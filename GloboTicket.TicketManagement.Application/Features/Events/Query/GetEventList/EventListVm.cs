﻿using System;

namespace GloboTicket.TicketManagement.Application.Features.Events.Query.GetEventList
{
    public class EventListVm
    {
        public Guid EventId { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string ImageUrl { get; set; }
    }
}