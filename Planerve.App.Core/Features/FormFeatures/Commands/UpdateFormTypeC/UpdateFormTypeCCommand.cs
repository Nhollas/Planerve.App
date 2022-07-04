using MediatR;
using System;

namespace Planerve.App.Core.Features.FormFeatures.Commands.UpdateFormTypeC
{
    public class UpdateFormTypeCCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
