using MediatR;
using System;

namespace Planerve.App.Core.Features.FormFeatures.Commands.UpdateForm
{
    public class UpdateFormCommand : IRequest
    {
        public Guid Id { get; set; }
        public int Type { get; set; }
        public object Form { get; set; }
    }
}
