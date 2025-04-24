using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using GloboTicket.TicketManagement.Application.Contracts.Persistence;
using GloboTicket.TicketManagement.Application.Features.Categories.Queries.GetCategoriesList;
using MediatR;

namespace GloboTicket.TicketManagement.Application.Features.Categories.Queries.GetCategoriesListWithEvents
{
    public class
        GetCategoriesListWithEventsQueryHandler : IRequestHandler<GetCategoriesListWithEventsQuery,
        List<CategoryListVm>>
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public GetCategoriesListWithEventsQueryHandler(IMapper mapper, ICategoryRepository categoryRepository)
        {
            _mapper = mapper;
            _categoryRepository = categoryRepository;
        }

        public async Task<List<CategoryListVm>> Handle(GetCategoriesListWithEventsQuery request,
            CancellationToken cancellationToken)
        {
            var list = await _categoryRepository.GetCategoriesWithEvents(request.IncludeHistory);
            return _mapper.Map<List<CategoryListVm>>(list);
        }
    }
}