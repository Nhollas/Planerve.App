using Planerve.App.Domain.Entities.ApplicationEntities;
using Planerve.App.Domain.Entities.FormEntities;
using Planerve.App.Domain.Entities.FormEntities.Shared;

namespace Planerve.App.Core.Interfaces.Persistence.Generic;

public interface IUnitOfWork
{
    IAsyncRepository<Application> ApplicationRepository { get; }
    IAsyncRepository<Submission> SubmissionRepository { get; }
    IAsyncRepository<FormTypeA> FormTypeARepository { get; }
    IAsyncRepository<FormTypeB> FormTypeBRepository { get; }
    IAsyncRepository<FormTypeC> FormTypeCRepository { get; }
    IAsyncRepository<FormTypeD> FormTypeDRepository { get; }
    IAsyncRepository<FormTypeE> FormTypeERepository { get; }
    IAsyncRepository<AccessSection> AccessSectionRepository { get; }
    IAsyncRepository<AdviceSection> AdviceSectionRepository { get; }
    IAsyncRepository<AgentSection> AgentSectionRepository { get; }
    IAsyncRepository<ApplicantSection> ApplicantSectionRepository { get; }
    IAsyncRepository<AuthorityMemberSection> AuthorityMemberSectionRepository { get; }
    IAsyncRepository<BiodiversitySection> BiodiversitySectionRepository { get; } 
    IAsyncRepository<ConditionProposalSection> ConditionProposalSectionRepository { get; }
    IAsyncRepository<DischargeConditionSection> DischargeConditionSectionRepository { get; }
    IAsyncRepository<EligibilitySection> EligibilitySectionRepository { get; }
    IAsyncRepository<EmploymentSection> EmploymentSectionRepository { get; }
    IAsyncRepository<ExistingUseSection> ExistingUseSectionRepository { get; }
    IAsyncRepository<FloodRiskSection> FloodRiskSectionRepository { get; }
    IAsyncRepository<FloorSpaceSection> FloorSpaceSectionRepository { get; }
    IAsyncRepository<FoulSewageSection> FoulSewageSectionRepository { get; }
    IAsyncRepository<HazardousSubstanceSection> HazardousSubstanceSectionRepository { get; }
    IAsyncRepository<IndustrialMachinerySection> IndustrialMachinerySectionRepository { get; }
    IAsyncRepository<MaterialSection> MaterialSectionRepository { get; }
    IAsyncRepository<NonMaterialProposalSection> NonMaterialProposalSectionRepository { get; }
    IAsyncRepository<NonMaterialSoughtSection> NonMaterialSoughtSectionRepository { get; }
    IAsyncRepository<OpeningHoursSection> OpeningHoursSectionRepository { get; }
    IAsyncRepository<OwnershipCertificationSection> OwnershipCertificationSectionRepository { get; }
    IAsyncRepository<ParkingSection> ParkingSectionRepository { get; }
    IAsyncRepository<ProposalSection> ProposalSectionRepository { get; }
    IAsyncRepository<ResidentialUnitsSection> ResidentialUnitsSectionRepository { get; }
    IAsyncRepository<SiteSection> SiteSectionRepository { get; }
    IAsyncRepository<SiteVisitSection> SiteVisitSectionRepository { get; }
    IAsyncRepository<TradeEffluentSection> TradeEffluentSectionRepository { get; }
    IAsyncRepository<TreeAndHedgeSection> TreeAndHedgeSectionRepository { get; }
    IAsyncRepository<VariationConditionSection> VariationConditionSectionRepository { get; }
    IAsyncRepository<WasteSection> WasteSectionRepository { get; }
}
