using FluentValidation;

namespace Planerve.App.Core.Features.ApplicationData.Commands.CreateApplication;

public class CreateApplicationCommandValidator : AbstractValidator<CreateApplicationCommand>
{

    public CreateApplicationCommandValidator()
    {
        RuleFor(e => e.ApplicationName)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .NotNull();
            RuleFor(e => e.Postcode)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .NotNull();
        RuleFor(e => e.ApplicationType)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .NotNull();
        RuleFor(e => e.AddressLineOne)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .NotNull(); 
    }
}