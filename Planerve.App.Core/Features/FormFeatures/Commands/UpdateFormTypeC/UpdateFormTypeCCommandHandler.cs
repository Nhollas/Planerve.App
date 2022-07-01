using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Planerve.App.Core.Features.FormFeatures.Commands.UpdateFormTypeC;
public class UpdateFormTypeCCommandHandler : IRequestHandler<UpdateFormTypeCCommand>
{
    public Task<Unit> Handle(UpdateFormTypeCCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
