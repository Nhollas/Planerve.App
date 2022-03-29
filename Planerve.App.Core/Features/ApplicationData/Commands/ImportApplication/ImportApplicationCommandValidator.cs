using FluentValidation;

namespace Planerve.App.Core.Features.ApplicationData.Commands.ImportApplication
{
    public class ImportApplicationCommandValidator : AbstractValidator<ImportApplicationCommand>
    {

        public ImportApplicationCommandValidator()
        {
            RuleFor(e => e.AccessToken)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull();
        }
    }
}
