using FluentValidation;
using System;

namespace Planerve.App.Core.Features.ApplicationData.Commands.CreateAccessToken
{
    public class CreateAccessTokenCommandValidator : AbstractValidator<CreateAccessTokenCommand>
    {
        public CreateAccessTokenCommandValidator()
        {
            RuleFor(p => p.ApplicationId)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull();

            RuleFor(p => p.TokenLifetime)
                .Must(BeAValidDate).WithMessage("Minumum token lifetime is 1 hour.");

            RuleFor(p => p.TokenUses).GreaterThanOrEqualTo(1)
                .WithMessage("The minumum uses is 1.");

            RuleFor(p => p.TokenUses).InclusiveBetween(1, 10)
                .WithMessage("A token can be used 10 times.");
        }

        private bool BeAValidDate(DateTime date)
        {
            if (date < DateTime.Now.AddHours(1))
            {
                return false;
            }
            return true;
        }
    }
}
