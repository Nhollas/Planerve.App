using MediatR;
using System;

namespace Planerve.App.Core.Features.ApplicationData.Queries.DownloadApplicationById;

public class GetApplicationDownloadQuery : IRequest<DownloadExportFileVm>
{
    public Guid Id { get; set; }
}