using Planerve.App.Core.Classes;
using Planerve.App.Domain.Entities.FormEntities;
using System;

namespace Planerve.App.Core.Specification.FormQueries
{
    public class GetFormTypeBSpecification : BaseSpecification<FormTypeB>
    {
        public GetFormTypeBSpecification(Guid queryId) : base(x => x.FormId == queryId)
        {
            AddInclude(x => x.SiteSection);
            AddInclude(x => x.ApplicantSection);
            AddInclude(x => x.AgentSection);
            AddInclude(x => x.ProposalSection);
            AddInclude(x => x.ExistingUseSection);
            AddInclude(x => x.MaterialSection);
            AddInclude(x => x.AccessSection);
            AddInclude(x => x.ParkingSection);
            AddInclude(x => x.TreeAndHedgeSection);
            AddInclude(x => x.FloodRiskSection);
            AddInclude(x => x.BiodiversitySection);
            AddInclude(x => x.FoulSewageSection);
            AddInclude(x => x.WasteSection);
            AddInclude(x => x.TradeEffluentSection);
            AddInclude(x => x.ResidentialUnitsSection);
            AddInclude(x => x.FloorSpaceSection);
            AddInclude(x => x.EmploymentSection);
            AddInclude(x => x.OpeningHoursSection);
            AddInclude(x => x.IndustrialMachinerySection);
            AddInclude(x => x.HazardousSubstanceSection);
            AddInclude(x => x.SiteVisitSection);
            AddInclude(x => x.AdviceSection);
            AddInclude(x => x.AuthorityMemberSection);
            AddInclude(x => x.OwnershipCertificationSection);
        }
    }
}
