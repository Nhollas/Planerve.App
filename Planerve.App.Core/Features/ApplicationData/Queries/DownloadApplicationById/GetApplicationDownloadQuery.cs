using System;
using Planerve.App.Domain.Entities;
using Planerve.App.Domain.Entities.ApplicationEntities;
using Kevsoft.PDFtk;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Planerve.App.Core.Features.ApplicationData.Queries.DownloadApplicationById;

public class GetApplicationDownloadQuery : IRequest <DownloadExportFileVm>
{
    public Guid Id { get; set; }
}