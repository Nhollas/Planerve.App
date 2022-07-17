using FluentValidation;

namespace Planerve.App.Core.Features.ApplicationFeatures.Commands.Create
{
    public class CreateApplicationCommandValidator : AbstractValidator<CreateApplicationCommand>
    {
        public CreateApplicationCommandValidator()
        {
            RuleFor(e => e.ApplicationName)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull();
            RuleFor(e => e.ApplicationType)
                .InclusiveBetween(1, 5).WithMessage("{PropertyName} must be between 1 and 5")
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull();
            RuleFor(e => e.ApplicationCategory)
                .InclusiveBetween(1, 3).WithMessage("{PropertyName} must be between 1 and 3")
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull();
        }
    }
}