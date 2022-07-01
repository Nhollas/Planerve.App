using System;

namespace Planerve.App.Core.Features.ApplicationFeatures.Dtos
{
    public class ApplicationProgressDto
    {
        public Guid Id { get; set; }
        public string ApplicationStatus { get; set; }
        public int ProgressPercentage { get; set; }
        public bool FormSectionsComplete { get; set; }
        public bool PlansAndDocsComplete { get; set; }
        public bool CalculatedFee { get; set; }
        public bool SubmittedToLocalAuthority { get; set; }
    }
}
