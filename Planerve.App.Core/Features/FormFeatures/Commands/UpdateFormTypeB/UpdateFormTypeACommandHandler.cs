using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Planerve.App.Core.Features.FormFeatures.Commands.UpdateFormTypeB;
public class UpdateFormTypeBCommandHandler : IRequestHandler<UpdateFormTypeBCommand>
{
    public Task<Unit> Handle(UpdateFormTypeBCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
