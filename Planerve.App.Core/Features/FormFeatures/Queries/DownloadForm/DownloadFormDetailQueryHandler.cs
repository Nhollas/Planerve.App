using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Planerve.App.Core.Features.FormFeatures.Queries.DownloadForm
{
    public class DownloadFormDetailQueryHandler : IRequestHandler<DownloadFormDetailQuery, DownloadFormVM>
    {
        public Task<DownloadFormVM> Handle(DownloadFormDetailQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
