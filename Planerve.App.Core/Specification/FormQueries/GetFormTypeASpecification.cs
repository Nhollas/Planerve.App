using Planerve.App.Core.Classes;
using Planerve.App.Domain.Entities.FormEntities;
using System;

namespace Planerve.App.Core.Specification.FormQueries
{
    public class GetFormTypeASpecification : BaseSpecification<FormTypeA>
    {
        public GetFormTypeASpecification(Guid queryId) : base(x => x.FormId == queryId)
        {
            AddInclude(x => x.SiteSection);
            AddInclude(x => x.ApplicantSection);
            AddInclude(x => x.AgentSection);
            AddInclude(x => x.ProposalSection);
            AddInclude(x => x.MaterialSection);
            AddInclude(x => x.TreeAndHedgeSection);
            AddInclude(x => x.AccessSection);
            AddInclude(x => x.ParkingSection);
            AddInclude(x => x.SiteVisitSection);
            AddInclude(x => x.AdviceSection);
            AddInclude(x => x.AuthorityMemberSection);
            AddInclude(x => x.OwnershipCertificationSection);
        }
    }
}
