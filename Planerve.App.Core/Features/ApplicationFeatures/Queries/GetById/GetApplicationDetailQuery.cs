using MediatR;
using System;

namespace Planerve.App.Core.Features.ApplicationFeatures.Queries.GetApplicationById
{
    public class GetApplicationDetailQuery : IRequest<ApplicationDetailVm>
    {
        public Guid Id { get; set; }
    }
}