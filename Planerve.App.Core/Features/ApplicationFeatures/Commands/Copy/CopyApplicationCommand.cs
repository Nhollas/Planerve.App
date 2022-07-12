using MediatR;
using System;

namespace Planerve.App.Core.Features.ApplicationFeatures.Commands.Copy
{
    public class CopyApplicationCommand : IRequest<Guid>
    {
        public Guid ApplicationId { get; set; }
        public string ApplicationName { get; set; }
        public bool ApplicantDetails { get; set; }
        public bool AgentDetails { get; set; }
        public bool SiteDetails { get; set; }
    }
}
