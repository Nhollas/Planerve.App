using Planerve.App.Domain.Common;
using Planerve.App.Domain.Entities.FormEntities.Shared;
using System;
using System.ComponentModel.DataAnnotations;

namespace Planerve.App.Domain.Entities.FormEntities
{
    // Non-Material Amendment
    public class FormTypeD : AuditableEntity
    {
        public void Initialize(Guid formId)
        {
            FormId = formId;
            SiteSection = new SiteSection() { Id = formId };
            ApplicantSection = new ApplicantSection() { Id = formId };
            AgentSection = new AgentSection() { Id = formId };
            EligibilitySection = new EligibilitySection() { Id = formId };
            NonMaterialProposalSection = new NonMaterialProposalSection() { Id = formId };
            NonMaterialSoughtSection = new NonMaterialSoughtSection() { Id = formId };
            SiteVisitSection = new SiteVisitSection() { Id = formId };
            AdviceSection = new AdviceSection() { Id = formId };
            AuthorityMemberSection = new AuthorityMemberSection() { Id = formId };
        }

        [Key]
        public Guid FormId { get; set; }
        public SiteSection SiteSection { get; set; }
        public ApplicantSection ApplicantSection { get; set; }
        public AgentSection AgentSection { get; set; }
        public EligibilitySection EligibilitySection { get; set; }
        public NonMaterialProposalSection NonMaterialProposalSection { get; set; }
        public NonMaterialSoughtSection NonMaterialSoughtSection { get; set; }
        public SiteVisitSection SiteVisitSection { get; set; }
        public AdviceSection AdviceSection { get; set; }
        public AuthorityMemberSection AuthorityMemberSection { get; set; }
    }
}
