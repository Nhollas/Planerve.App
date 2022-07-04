using MediatR;
using System;

namespace Planerve.App.Core.Features.FormFeatures.Commands.UpdateFormTypeD
{
    public class UpdateFormTypeDCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
