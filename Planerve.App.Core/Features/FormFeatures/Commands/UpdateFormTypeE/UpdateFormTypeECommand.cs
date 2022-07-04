using MediatR;
using System;

namespace Planerve.App.Core.Features.FormFeatures.Commands.UpdateFormTypeE
{
    public class UpdateFormTypeECommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
