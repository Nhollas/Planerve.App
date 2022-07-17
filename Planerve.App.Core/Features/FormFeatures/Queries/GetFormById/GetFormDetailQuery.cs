using MediatR;
using System;

namespace Planerve.App.Core.Features.FormFeatures.Queries.GetFormById
{
    public class GetFormDetailQuery : IRequest<FormDetailVM>
    {
        public Guid FormId { get; set; }
    }
}
