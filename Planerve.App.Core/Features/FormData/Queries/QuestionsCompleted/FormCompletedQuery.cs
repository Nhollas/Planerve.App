using MediatR;
using Planerve.App.Core.Features.FormData.Queries.GetFormById;
using System;

namespace Planerve.App.Core.Features.FormData.Queries.QuestionsCompleted
{
    public class FormCompletedQuery : IRequest<FormCompletedVm>
    {
        public Guid Id { get; set; }
    }
}
