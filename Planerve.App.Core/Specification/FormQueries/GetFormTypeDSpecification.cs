using Planerve.App.Core.Classes;
using Planerve.App.Domain.Entities.FormEntities;
using System;

namespace Planerve.App.Core.Specification.FormQueries
{
    public class GetFormTypeDSpecification : BaseSpecification<FormTypeD>
    {
        public GetFormTypeDSpecification(Guid queryId) : base(x => x.FormId == queryId)
        {
            AddInclude(x => x.SiteSection);
            AddInclude(x => x.ApplicantSection);
            AddInclude(x => x.AgentSection);
            AddInclude(x => x.EligibilitySection);
            AddInclude(x => x.NonMaterialProposalSection);
            AddInclude(x => x.NonMaterialSoughtSection);
            AddInclude(x => x.SiteVisitSection);
            AddInclude(x => x.AdviceSection);
            AddInclude(x => x.AuthorityMemberSection);
        }
    }
}
