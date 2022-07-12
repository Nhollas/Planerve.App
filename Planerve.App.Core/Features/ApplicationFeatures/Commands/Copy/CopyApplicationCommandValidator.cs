using FluentValidation;

namespace Planerve.App.Core.Features.ApplicationFeatures.Commands.Copy
{
    public class CopyApplicationCommandValidator : AbstractValidator<CopyApplicationCommand>
    {
        public CopyApplicationCommandValidator()
        {
            RuleFor(e => e.ApplicationId)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull();
            RuleFor(e => e.ApplicationName)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull();
        }
    }
}
