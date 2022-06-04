using MediatR;
using System;

namespace Planerve.App.Core.Features.ApplicationFeatures.Commands.ShareApplication
{
    public class ShareApplicationCommand : IRequest
    {
        public Guid ApplicationId { get; set; }
        public string UsernameOrEmail { get; set; }
    }
}
