using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Planerve.App.Core.Features.FormFeatures.Commands.UpdateFormTypeE;
public class UpdateFormTypeECommandHandler : IRequestHandler<UpdateFormTypeECommand>
{
    public Task<Unit> Handle(UpdateFormTypeECommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
