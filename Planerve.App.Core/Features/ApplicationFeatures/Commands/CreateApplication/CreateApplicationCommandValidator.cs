using FluentValidation;

namespace Planerve.App.Core.Features.ApplicationFeatures.Commands.CreateApplication
{
    public class CreateApplicationCommandValidator : AbstractValidator<CreateApplicationCommand>
    {
        public CreateApplicationCommandValidator()
        {
            RuleFor(e => e.ApplicationName)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull();
            RuleFor(e => e.ApplicationType)
                .ExclusiveBetween(0, 21).WithMessage("{PropertyName} must be between 1 and 20")
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull();
            RuleFor(e => e.ApplicationCategory)
                .ExclusiveBetween(0, 4).WithMessage("{PropertyName} must be between 1 and 3")
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull();
        }
    }
}