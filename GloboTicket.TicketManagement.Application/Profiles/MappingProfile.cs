using AutoMapper;
using GloboTicket.TicketManagement.Application.Features.Categories.Queries.GetCategoriesList;
using GloboTicket.TicketManagement.Application.Features.Categories.Queries.GetCategoriesListWithEvents;
using GloboTicket.TicketManagement.Application.Features.Events;
using GloboTicket.TicketManagement.Application.Features.Events.Query.Commands.CreateEvent;
using GloboTicket.TicketManagement.Application.Features.Events.Query.Commands.UpdateEvent;
using GloboTicket.TicketManagement.Domain.Entities;

namespace GloboTicket.TicketManagement.Application.Profiles
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Event, EventListVm>().ReverseMap();
            CreateMap<Event, EventDetailVm>().ReverseMap();
            CreateMap<Category, CategoryDto>();
            CreateMap<Category, CategoryListVm>();
            CreateMap<Category, CategoryEventListVm>();
            CreateMap<Category, CreateEventCommand>().ReverseMap();
            CreateMap<Category, UpdateEventCommand>().ReverseMap();
        }
    }
}