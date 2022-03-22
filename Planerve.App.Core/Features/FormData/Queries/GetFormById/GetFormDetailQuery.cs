using MediatR;
using System;

namespace Planerve.App.Core.Features.FormData.Queries.GetFormById;

public class GetFormDetailQuery : IRequest<FormDetailVm>
{
    public Guid Id { get; set; }
}