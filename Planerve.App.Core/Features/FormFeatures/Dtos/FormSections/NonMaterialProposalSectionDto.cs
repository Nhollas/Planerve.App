using System;

namespace Planerve.App.Core.Features.FormFeatures.Dtos.FormSections
{
    public class NonMaterialProposalSectionDto
    {
        public string ApprovedDescription { get; set; }
        public string ReferenceNumber { get; set; }
        public DateTimeOffset DecisionDate { get; set; }
        public string OriginalApplicationType { get; set; }
        public string OriginalDevelopmentType { get; set; }
    }
}
