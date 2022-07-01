using Planerve.App.Domain.Common;
using Planerve.App.Domain.Entities.FormEntities.Shared;
using System;
using System.ComponentModel.DataAnnotations;

namespace Planerve.App.Domain.Entities.FormEntities
{
    // Non-Material Amendment
    public class FormTypeD : AuditableEntity
    {
        [Key]
        public Guid ApplicationId { get; set; }
        public ApplicantSection ApplicantSection { get; set; }
        public AgentSection AgentSection { get; set; }
        public SiteSection SiteSection { get; set; }
        public AdviceSection AdviceSection { get; set; }
        public AuthorityMemberSection AuthorityMemberSection { get; set; }
        public ProposalSection ProposalSection { get; set; }
        public SiteVisitSection SiteVisitSection { get; set; }
    }
}
