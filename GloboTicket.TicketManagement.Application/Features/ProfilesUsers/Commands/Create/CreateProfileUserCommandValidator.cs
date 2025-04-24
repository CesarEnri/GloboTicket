using FluentValidation;

namespace GloboTicket.TicketManagement.Application.Features.ProfilesUsers.Commands.Create
{
    public class CreateProfileUserCommandValidator : AbstractValidator<CreateProfileUserCommand>
    {
        public CreateProfileUserCommandValidator()
        {
            RuleFor(p => p.FirstName)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MaximumLength(50).WithMessage("{PropertyName} must not exceed 10 characters.");

            RuleFor(p => p.LastName)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MaximumLength(50).WithMessage("{PropertyName} must not exceed 10 characters.");
        }
    }
}