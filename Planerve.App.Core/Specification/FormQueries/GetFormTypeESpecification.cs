using Planerve.App.Core.Classes;
using Planerve.App.Domain.Entities.FormEntities;
using System;

namespace Planerve.App.Core.Specification.FormQueries
{
    public class GetFormTypeESpecification : BaseSpecification<FormTypeE>
    {
        public GetFormTypeESpecification(Guid queryId) : base(x => x.FormId == queryId)
        {
            AddInclude(x => x.SiteSection);
            AddInclude(x => x.ApplicantSection);
            AddInclude(x => x.AgentSection);
            AddInclude(x => x.ConditionProposalSection);
            AddInclude(x => x.VariationConditionSection);
            AddInclude(x => x.SiteVisitSection);
            AddInclude(x => x.AdviceSection);
            AddInclude(x => x.OwnershipCertificationSection);
        }
    }
}
