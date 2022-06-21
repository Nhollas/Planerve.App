using Planerve.App.Domain.Entities.ApplicationEntities;
using System;

namespace Planerve.App.Core.Features.ApplicationFeatures.Dtos
{
    public class ApplicationDataDto
    {
        public Guid Id { get; set; }
        public ApplicationType Type { get; set; }
        public ApplicationAddress Address { get; set; }
        public ApplicationDocument Document { get; set; }
        public ApplicationProgress Progress { get; set; }
    }
}
