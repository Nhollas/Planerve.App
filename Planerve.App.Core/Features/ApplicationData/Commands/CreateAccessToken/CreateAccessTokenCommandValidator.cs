using FluentValidation;
using System;

namespace Planerve.App.Core.Features.ApplicationData.Commands.CreateAccessToken
{
    public class CreateAccessTokenCommandValidator : AbstractValidator<CreateAccessTokenCommand>
    {
        public CreateAccessTokenCommandValidator()
        {
            RuleFor(p => p.TokenAccessLevel)
                .InclusiveBetween(1, 5);

            RuleFor(p => p.TokenAccessLevel)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull();

            RuleFor(p => p.ApplicationId)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull();
            
            RuleFor(p => p.TokenLifetime)
                .Must(BeAValidDate).WithMessage("Minumum token lifetime is 1 hour.");
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
