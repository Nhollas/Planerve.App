using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Planerve.App.Core.Features.FormFeatures.Commands.UpdateFormTypeD;
public class UpdateFormTypeDCommandHandler : IRequestHandler<UpdateFormTypeDCommand>
{
    public Task<Unit> Handle(UpdateFormTypeDCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
