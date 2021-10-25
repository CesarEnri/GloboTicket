using System.Collections.Generic;
using GloboTicket.TicketManagement.Application.Features.Categories.Queries.GetCategoriesList;
using MediatR;

namespace GloboTicket.TicketManagement.Application.Features.Categories.Queries.GetCategoriesListWithEvents
{
    public class GetCategoriesListWithEventsQuery : IRequest<List<CategoryListVm>>
    {
        public bool IncludeHistory { get; set; }
    }
}