using System;
using MediatR;

namespace GloboTicket.TicketManagement.Application.Features.Events.Query.Commands.DeleteEvent
{
    public class DeleteEventCommand: IRequest
    {
        public Guid EventId { get; set; }
    }
}