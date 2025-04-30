using System.Collections.Generic;
using GloboTicket.TicketManagement.Application.Features.Events.Query.GetEventList;
using MediatR;

namespace GloboTicket.TicketManagement.Application.Features.Events
{
    public class GetEventsListQuery : IRequest<List<EventListVm>>
    {
    }
}