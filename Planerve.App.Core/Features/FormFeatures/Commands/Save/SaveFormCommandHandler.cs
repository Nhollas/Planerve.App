using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Planerve.App.Core.Features.FormFeatures.Commands.Save
{
    public class SaveFormCommandHandler : IRequestHandler<SaveFormCommand>
    {
        public Task<Unit> Handle(SaveFormCommand request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}
