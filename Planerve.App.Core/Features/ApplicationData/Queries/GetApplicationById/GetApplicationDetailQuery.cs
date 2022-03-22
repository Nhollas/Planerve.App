using MediatR;
using System;

namespace Planerve.App.Core.Features.ApplicationData.Queries.GetApplicationById;

public class GetApplicationDetailQuery : IRequest<ApplicationDetailVm>
{
    public Guid Id { get; set; }
}