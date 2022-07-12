using System;

namespace Planerve.App.Domain.Entities.FormEntities.Shared
{
    public class NonMaterialProposalSection
    {
        public Guid Id { get; set; }
        public string ApprovedDescription { get; set; }
        public string ReferenceNumber { get; set; }
        public DateTimeOffset DecisionDate { get; set; }
        public string OriginalApplicationType { get; set; }
        public string OriginalDevelopmentType { get; set; }
    }
}
