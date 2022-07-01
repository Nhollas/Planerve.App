using MediatR;
using System;

namespace Planerve.App.Core.Features.FormFeatures.Queries.GetFormById
{
    public class GetFormDetailQuery : IRequest<FormDetailVM>
    {
        public Guid Id { get; set; }
        public int Type { get; set; }
    }
}
