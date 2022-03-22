using FluentValidation;
using Planerve.App.Core.Contracts.Persistence;
using System.Threading;
using System.Threading.Tasks;

namespace Planerve.App.Core.Features.ApplicationData.Commands.CreateApplication;

public class CreateApplicationCommandValidator : AbstractValidator<CreateApplicationCommand>
{
    private readonly IApplicationDataRepository _appDataRepository;

    public CreateApplicationCommandValidator(IApplicationDataRepository appDataRepository)
    {
        _appDataRepository = appDataRepository;
    }

    public CreateApplicationCommandValidator()
    {
        RuleFor(e => e)
            .MustAsync(AppReferenceNameUnique)
            .WithMessage("An application with this reference already exists.");
        RuleFor(e => e.ApplicationType)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .NotNull();
    }

    private async Task<bool> AppReferenceNameUnique(CreateApplicationCommand e, CancellationToken token)
    {
        return !await _appDataRepository.IsAppReferenceNameUnique(e.ApplicationReference);
    }
}