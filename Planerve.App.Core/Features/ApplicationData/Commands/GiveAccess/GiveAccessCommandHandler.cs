using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Planerve.App.Core.Contracts.Persistence;

namespace Planerve.App.Core.Features.ApplicationData.Commands.GiveAccess;

public class GiveAccessCommandHandler : IRequestHandler<GiveAccessCommand>
{
    private readonly IApplicationDataRepository _appDataRepository;
    
    public GiveAccessCommandHandler(IApplicationDataRepository appDataRepository)
    {
        _appDataRepository = appDataRepository;
    }
    
    public Task<Unit> Handle(GiveAccessCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}