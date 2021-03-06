using System;
using System.Collections.Generic;
using MediatR;

namespace GloboTicket.TicketManagement.Application.Features.Events
{
    public class GetEventDetailQuery: IRequest<EventDetailVm>, IRequest<List<EventListVm>>
    {
        public Guid Id { get; set; }
    }
}