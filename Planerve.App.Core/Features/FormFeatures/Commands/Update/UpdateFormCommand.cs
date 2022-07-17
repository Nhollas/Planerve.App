using MediatR;
using System;
using System.Text.Json.Nodes;

namespace Planerve.App.Core.Features.FormFeatures.Commands.Update
{
    public class UpdateFormCommand : IRequest
    {
        public Guid FormId { get; set; }
        public string Section { get; set; }
        public JsonObject Data { get; set; }
    }
}
