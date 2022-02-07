using AutoMapper;
using MediatR;
using Planerve.App.Core.Contracts.Persistence;
using Planerve.App.Core.Exceptions;
using Planerve.App.Domain.Entities.ApplicationEntities;
using System.Threading;
using System.Threading.Tasks;

namespace Planerve.App.Core.Features.ApplicationData.Commands.DeleteApplication;

public class DeleteApplicationCommandHandler : IRequestHandler<DeleteApplicationCommand>
{
    private readonly IApplicationDataRepository _appDataRepository;

    public DeleteApplicationCommandHandler(IMapper mapper, IApplicationDataRepository appDataRepository)
    {
        _appDataRepository = appDataRepository;
    }

    public async Task<Unit> Handle(DeleteApplicationCommand request, CancellationToken cancellationToken)
    {
        var applicationToDelete = await _appDataRepository.GetApplicationById(request.ApplicationId);

        if (applicationToDelete == null) throw new NotFoundException(nameof(Application), request.ApplicationId);

        await _appDataRepository.DeleteAsync(applicationToDelete);

        return Unit.Value;
    }
}