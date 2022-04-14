using FluentValidation;
using Planerve.App.Domain.Entities.FormEntities;

namespace Planerve.App.Core.Features.FormData.Commands.CompleteForm;

public class CompleteFormOneCommandValidator : AbstractValidator<FormTypeOne>
{
    public CompleteFormOneCommandValidator()
    {
        RuleFor(e => e.OneTextOne)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .NotNull();
    }
}

public class CompleteFormTwoCommandValidator : AbstractValidator<FormTypeTwo>
{
    public CompleteFormTwoCommandValidator()
    {
        RuleFor(e => e.OneTextOne)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .NotNull();
    }
}