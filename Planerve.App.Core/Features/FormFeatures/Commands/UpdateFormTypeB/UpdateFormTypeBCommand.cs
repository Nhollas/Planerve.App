using MediatR;
using Planerve.App.Core.Features.FormFeatures.Dtos;
using System;

namespace Planerve.App.Core.Features.FormFeatures.Commands.UpdateFormTypeB
{
    public class UpdateFormTypeBCommand : IRequest
    {
        public Guid Id { get; set; }
        public ApplicantSectionDto ApplicantSection { get; set; }
        public AgentSectionDto AgentSection { get; set; }
        public ProposalSectionDto ProposalSection { get; set; }
        public SiteSectionDto SiteSection { get; set; }
        public AdviceSectionDto AdviceSection { get; set; }
        public AccessSectionDto AccessSection { get; set; }
        public WasteSectionDto WasteSection { get; set; }
        public AuthorityMemberSectionDto AuthorityMemberSection { get; set; }
        public MaterialSectionDto MaterialSection { get; set; }
        public ParkingSectionDto ParkingSection { get; set; }
        public FoulSewageSectionDto FoulSewageSection { get; set; }
        public FloodRiskSectionDto FloodRiskSection { get; set; }
        public BiodiversitySectionDto BiodiversitySection { get; set; }
        public ExistingUseSectionDto ExistingUseSection { get; set; }
        public TreeAndHedgeSectionDto TreeAndHedgeSection { get; set; }
        public TradeEffluentSectionDto TradeEffluentSection { get; set; }
        public EmploymentSectionDto EmploymentSection { get; set; }
        public OpeningHoursSectionDto OpeningHoursSection { get; set; }
        public IndustrialMachinerySectionDto IndustrialMachinerySection { get; set; }
        public HazardousSubstanceSectionDto HazardousSubstanceSection { get; set; }
        public OwnershipCertificationSectionDto OwnershipCertificationSection { get; set; }
        public SiteVisitSectionDto SiteVisitSection { get; set; }
    }
}
