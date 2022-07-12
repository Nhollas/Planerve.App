using System;
using MediatR;

namespace Planerve.App.Core.Features.ApplicationFeatures.Commands.Delete
{
    public class DeleteApplicationCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}