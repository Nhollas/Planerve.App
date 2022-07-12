using Planerve.App.Domain.Common;
using Planerve.App.Domain.Entities.FormEntities.Shared;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Planerve.App.Domain.Entities.FormEntities
{
    // Non-Material Amendment
    public class FormTypeD : AuditableEntity
    {
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
