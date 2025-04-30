using FluentValidation;
using GloboTicket.TicketManagement.Application.Features.Roles.Commands.Create;

namespace GloboTicket.TicketManagement.Application.Features.Permissions.Commands.Create
{
    public class CreatePermissionCommandValidator: AbstractValidator<CreatePermissionCommand>
    {
        public CreatePermissionCommandValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters.");
            RuleFor(p => p.Description)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MaximumLength(100).WithMessage("{PropertyName} must not exceed 100 characters.");
        }
    }
}