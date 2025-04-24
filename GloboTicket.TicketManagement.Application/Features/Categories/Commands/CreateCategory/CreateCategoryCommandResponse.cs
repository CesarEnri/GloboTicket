using GloboTicket.TicketManagement.Application.Response;

namespace GloboTicket.TicketManagement.Application.Features.Categories.Commands.CreateCategory
{
    public class CreateCategoryCommandResponse : BaseResponse
    {
        public CreateCategoryDto Category { get; set; }
    }
}