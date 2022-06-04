using MediatR;
using System;

namespace Planerve.App.Core.Features.FormFeatures.Queries.GetFormById;

public class GetFormDetailQuery : IRequest<FormDetailVm>
{
    public Guid Id { get; set; }
}