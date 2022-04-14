using FluentValidation;
using Planerve.App.Domain.Entities.FormEntities;

namespace Planerve.App.Core.Features.FormData.Commands.UpdateForm
{
    public class UpdateFormOneCommandValidator : AbstractValidator<FormTypeOne>
    {
        public UpdateFormOneCommandValidator()
        {
            RuleFor(e => e.OneTextOne)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull();
        }
    }

    public class UpdateFormTwoCommandValidator : AbstractValidator<FormTypeTwo>
    {
        public UpdateFormTwoCommandValidator()
        {
            RuleFor(e => e.OneTextOne)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull();
        }
    }
}
