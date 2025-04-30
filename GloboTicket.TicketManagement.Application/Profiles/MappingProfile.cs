using AutoMapper;
using GloboTicket.TicketManagement.Application.Features.Categories.Commands.CreateCategory;
using GloboTicket.TicketManagement.Application.Features.Categories.Queries.GetCategoriesList;
using GloboTicket.TicketManagement.Application.Features.Categories.Queries.GetCategoriesListWithEvents;
using GloboTicket.TicketManagement.Application.Features.Events;
using GloboTicket.TicketManagement.Application.Features.Events.Query.Commands.CreateEvent;
using GloboTicket.TicketManagement.Application.Features.Events.Query.Commands.UpdateEvent;
using GloboTicket.TicketManagement.Application.Features.Events.Query.GetEventDetail;
using GloboTicket.TicketManagement.Application.Features.Events.Query.GetEventExport;
using GloboTicket.TicketManagement.Application.Features.Events.Query.GetEventList;
using GloboTicket.TicketManagement.Application.Features.Orders.GetOrdersForMonth;
using GloboTicket.TicketManagement.Application.Features.Permissions.Commands.Create;
using GloboTicket.TicketManagement.Application.Features.Permissions.Queries.GetPermissionsList;
using GloboTicket.TicketManagement.Application.Features.ProfilesUsers.Commands.Create;
using GloboTicket.TicketManagement.Application.Features.ProfilesUsers.Queries.GetUserPic;
using GloboTicket.TicketManagement.Application.Features.Roles.Commands.Create;
using GloboTicket.TicketManagement.Application.Features.Roles.Queries.GetRolesList;
using GloboTicket.TicketManagement.Domain.Entities;

namespace GloboTicket.TicketManagement.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // ??? ReverseMap ??
            CreateMap<Event, EventListVm>().ReverseMap();
            CreateMap<Event, CreateEventCommand>().ReverseMap();
            CreateMap<Event, UpdateEventCommand>().ReverseMap();
            CreateMap<Event, EventDetailVm>().ReverseMap();
            CreateMap<Event, CategoryEventDto>().ReverseMap();
            CreateMap<Event, EventExportDto>().ReverseMap();

            CreateMap<Category, CategoryDto>();
            CreateMap<Category, CategoryListVm>();
            CreateMap<Category, CategoryEventListVm>();
            CreateMap<Category, CreateCategoryCommand>();
            CreateMap<Category, CreateCategoryDto>();

            CreateMap<Order, OrdersForMonthDto>();

            //Profile users
            CreateMap<ProfileUser, CreateProfileUserDto>();
            
            // ??? : Eliana
            CreateMap<ProfileUser, GetUserPicDto>();

            // DTO -> VM
            // ??? : Eliana
            CreateMap<GetUserPicDto, GetUserPicQueryVm>();

            // Roles
            CreateMap<Role, CreateRoleDto>();
            CreateMap<Role, GetRolesListVm>();

            CreateMap<Permission, CreatePermissionDto>();
            CreateMap<Permission, GetPermissionsListVm>();
        }
    }
}