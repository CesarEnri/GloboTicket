using System;
using System.Collections.Generic;
using GloboTicket.TicketManagement.Application.Features.Events.Query.GetEventList;
using MediatR;

namespace GloboTicket.TicketManagement.Application.Features.Events.Query.GetEventDetail
{
    public class GetEventDetailQuery : IRequest<EventDetailVm>, IRequest<List<EventListVm>>
    {
        public Guid Id { get; set; }
    }
}