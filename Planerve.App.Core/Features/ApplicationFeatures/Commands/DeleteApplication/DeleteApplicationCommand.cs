using System;
using MediatR;

namespace Planerve.App.Core.Features.ApplicationFeatures.Commands.DeleteApplication
{
    public class DeleteApplicationCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}