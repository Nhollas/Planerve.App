using System.ComponentModel.DataAnnotations.Schema;
using Planerve.App.Domain.Common;
using Planerve.App.Domain.Entities.FormEntities.Shared;
using System;
using System.ComponentModel.DataAnnotations;

namespace Planerve.App.Domain.Entities.FormEntities
{
    // Removal/Variation of a condition
    public class FormTypeE : AuditableEntity
    {
        public void Initialize(Guid formId)
        {
            FormId = formId;
            SiteSection = new SiteSection() { Id = formId };
            ApplicantSection = new ApplicantSection() { Id = formId };
            AgentSection = new AgentSection() { Id = formId };
            ConditionProposalSection = new ConditionProposalSection() { Id = formId };
            VariationConditionSection = new VariationConditionSection() { Id = formId };
            SiteVisitSection = new SiteVisitSection() { Id = formId };
            AdviceSection = new AdviceSection() { Id = formId };
            OwnershipCertificationSection = new OwnershipCertificationSection() { Id = formId };
        }

        [Key]
        public Guid FormId { get; set; }
        public SiteSection SiteSection { get; set; }
        public ApplicantSection ApplicantSection { get; set; }
        public AgentSection AgentSection { get; set; }
        public ConditionProposalSection ConditionProposalSection { get; set; }
        public VariationConditionSection VariationConditionSection { get; set; }
        public SiteVisitSection SiteVisitSection { get; set; }
        public AdviceSection AdviceSection { get; set; }
        public OwnershipCertificationSection OwnershipCertificationSection { get; set; }
    }
}
