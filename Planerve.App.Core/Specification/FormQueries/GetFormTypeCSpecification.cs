using Planerve.App.Core.Classes;
using Planerve.App.Domain.Entities.FormEntities;
using System;

namespace Planerve.App.Core.Specification.FormQueries
{
    public class GetFormTypeCSpecification : BaseSpecification<FormTypeC>
    {
        public GetFormTypeCSpecification(Guid queryId) : base(x => x.FormId == queryId)
        {
            AddInclude(x => x.SiteSection);
            AddInclude(x => x.ApplicantSection);
            AddInclude(x => x.AgentSection);
            AddInclude(x => x.ConditionProposalSection);
            AddInclude(x => x.DischargeConditionSection);
            AddInclude(x => x.SiteVisitSection);
            AddInclude(x => x.AdviceSection);
        }
    }
}
