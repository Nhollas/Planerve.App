using AutoMapper;
using MediatR;
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

    public DeleteApplicationCommandHandler(IAsyncRepository<Application> repository, ILoggedInUserService loggedInUserService)
    {
        _repository = repository;
        _loggedInUserService = loggedInUserService;
    }

    public async Task<Unit> Handle(DeleteApplicationCommand request, CancellationToken cancellationToken)
    {
        // Grab userId from API user service.
        var userId = _loggedInUserService.UserId;

        // Get application by id and check that current user is the owner.
        var specification = new GetApplicationByIdSpecification(request.Id, userId);

        var applicationToDelete = _repository.FindWithSpecificationPattern(specification);

        if (!applicationToDelete.Any())
        {
            throw new NotFoundException(nameof(Application), request.Id);
        }

        var selectedApplication = applicationToDelete.First();

        if (!selectedApplication.AuthorisedUsers.Any(x => x.UserId == userId))
        {
            throw new NotAuthorisedException(nameof(Application), userId);
        }

        await _repository.DeleteAsync(selectedApplication);

        return Unit.Value;
    }
}