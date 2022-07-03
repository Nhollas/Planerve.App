using Planerve.App.Domain.Common;
using Planerve.App.Domain.Entities.FormEntities.Shared;
using System;
using System.ComponentModel.DataAnnotations;

namespace Planerve.App.Domain.Entities.FormEntities
{
    // Approval of details reserved by a condition (Discharge)
    public class FormTypeC : AuditableEntity
    {
        [Key]
        public Guid ApplicationId { get; set; }
        public SiteSection SiteSection { get; set; }
        public ApplicantSection ApplicantSection { get; set; }
        public AgentSection AgentSection { get; set; }
        public DischargeProposalSection DischargeProposalSection { get; set; }
        public SiteVisitSection SiteVisitSection { get; set; }
        public AdviceSection AdviceSection { get; set; }
        public bool DischargePartOnly { get; set; }
        public string PartsDescription { get; set; }
        public string SubmittedInformation { get; set; }
    }
}
