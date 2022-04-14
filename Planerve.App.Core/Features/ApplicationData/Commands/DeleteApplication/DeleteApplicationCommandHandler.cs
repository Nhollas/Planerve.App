using MediatR;
using Microsoft.AspNetCore.Authorization;
using Planerve.App.Core.Contracts.Authorization;
using Planerve.App.Core.Contracts.Identity;
using Planerve.App.Core.Contracts.Persistence;
using Planerve.App.Core.Contracts.Specification.ApplicationData;
using Planerve.App.Core.Exceptions;
using Planerve.App.Domain.Entities.ApplicationEntities;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Planerve.App.Core.Features.ApplicationData.Commands.DeleteApplication;

public class DeleteApplicationCommandHandler : IRequestHandler<DeleteApplicationCommand>
{
    private readonly IAsyncRepository<Application> _repository;
    private readonly ILoggedInUserService _loggedInUserService;
    private readonly IAuthorizationService _authorizationService;

    public DeleteApplicationCommandHandler(IAsyncRepository<Application> repository, ILoggedInUserService loggedInUserService, IAuthorizationService authorizationService)
    {
        _repository = repository;
        _loggedInUserService = loggedInUserService;
        _authorizationService = authorizationService;
    }

    public async Task<Unit> Handle(DeleteApplicationCommand request, CancellationToken cancellationToken)
    {
        // Grab userId from API user service.
        var user = _loggedInUserService.GetUser().Result;
        var userId = _loggedInUserService.UserId().Result;

        var specification = new GetApplicationByIdSpecification(request.Id, userId);

        var applicationToDelete = _repository.FindWithSpecificationPattern(specification);

        var selectedApplication = applicationToDelete.First();

        var result = await _authorizationService.AuthorizeAsync(user, selectedApplication, ApplicationPolicies.DeleteApplication.Requirements);

        if (!result.Succeeded)
        {
            throw new NotAuthorisedException(nameof(Application), userId);
        }

        await _repository.DeleteAsync(selectedApplication);
        return Unit.Value;
    }
}
