using Planerve.App.Core.Features.FormFeatures.Dtos.FormSections;
using Planerve.App.Domain.Entities.FormEntities.Shared;

namespace Planerve.App.Core.Interfaces.Services
{
    public interface IFormSectionServiceProvider
    {
        IFormSectionService<AccessSection, AccessSectionDto> AccessSectionService { get; }
        IFormSectionService<AdviceSection, AdviceSectionDto> AdviceSectionService { get; }
        IFormSectionService<AgentSection, AgentSectionDto> AgentSectionService { get; }
        IFormSectionService<ApplicantSection, ApplicantSectionDto> ApplicantSectionService { get; }
        IFormSectionService<AuthorityMemberSection, AuthorityMemberSectionDto> AuthorityMemberSectionService { get; }
        IFormSectionService<BiodiversitySection, BiodiversitySectionDto> BiodiversitySectionService { get; } 
        IFormSectionService<ConditionProposalSection, ConditionProposalSectionDto> ConditionProposalSectionService { get; }
        IFormSectionService<DischargeConditionSection, DischargeConditionSectionDto> DischargeConditionSectionService { get; }
        IFormSectionService<EligibilitySection, EligibilitySectionDto> EligibilitySectionService { get; }
        IFormSectionService<EmploymentSection, EmploymentSectionDto> EmploymentSectionService { get; }
        IFormSectionService<ExistingUseSection, ExistingUseSectionDto> ExistingUseSectionService { get; }
        IFormSectionService<FloodRiskSection, FloodRiskSectionDto> FloodRiskSectionService { get; }
        IFormSectionService<FloorSpaceSection, FloorSpaceSectionDto> FloorSpaceSectionService { get; }
        IFormSectionService<FoulSewageSection, FoulSewageSectionDto> FoulSewageSectionService { get; }
        IFormSectionService<HazardousSubstanceSection, HazardousSubstanceSectionDto> HazardousSubstanceSectionService { get; }
        IFormSectionService<IndustrialMachinerySection, IndustrialMachinerySectionDto> IndustrialMachinerySectionService { get; }
        IFormSectionService<MaterialSection, MaterialSectionDto> MaterialSectionService { get; }
        IFormSectionService<NonMaterialProposalSection, NonMaterialProposalSectionDto> NonMaterialProposalSectionService { get; }
        IFormSectionService<NonMaterialSoughtSection, NonMaterialSoughtSectionDto> NonMaterialSoughtSectionService { get; }
        IFormSectionService<OpeningHoursSection, OpeningHoursSectionDto> OpeningHoursSectionService { get; }
        IFormSectionService<OwnershipCertificationSection, OwnershipCertificationSectionDto> OwnershipCertificationSectionService { get; }
        IFormSectionService<ParkingSection, ParkingSectionDto> ParkingSectionService { get; }
        IFormSectionService<ProposalSection, ProposalSectionDto> ProposalSectionService { get; }
        IFormSectionService<ResidentialUnitsSection, ResidentialUnitsSectionDto> ResidentialUnitsSectionService { get; }
        IFormSectionService<SiteSection, SiteSectionDto> SiteSectionService { get; }
        IFormSectionService<SiteVisitSection, SiteVisitSectionDto> SiteVisitSectionService { get; }
        IFormSectionService<TradeEffluentSection, TradeEffluentSectionDto> TradeEffluentSectionService { get; }
        IFormSectionService<TreeAndHedgeSection, TreeAndHedgeSectionDto> TreeAndHedgeSectionService { get; }
        IFormSectionService<VariationConditionSection, VariationConditionSectionDto> VariationConditionSectionService { get; }
        IFormSectionService<WasteSection, WasteSectionDto> WasteSectionService { get; }
    }
}