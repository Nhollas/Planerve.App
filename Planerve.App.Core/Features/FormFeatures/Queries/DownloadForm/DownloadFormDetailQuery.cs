using MediatR;
using System;

namespace Planerve.App.Core.Features.FormFeatures.Queries.DownloadForm
{
    public class DownloadFormDetailQuery : IRequest<DownloadFormVM>
    {
        public Guid Id { get; set; }
        public int Type { get; set; }
    }
}
