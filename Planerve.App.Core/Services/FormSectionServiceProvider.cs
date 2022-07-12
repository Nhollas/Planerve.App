using AutoMapper;
using Planerve.App.Core.Features.FormFeatures.Dtos.FormSections;
using Planerve.App.Core.Interfaces.Persistence.Generic;
using Planerve.App.Core.Interfaces.Services;
using Planerve.App.Domain.Entities.FormEntities.Shared;

namespace Planerve.App.Core.Services
{
    public class FormSectionServiceProvider : IFormSectionServiceProvider
    {
        private readonly IMapper _mapper;

        private IFormSectionService<AccessSection, AccessSectionDto> _accessSectionService;
        private IFormSectionService<AdviceSection, AdviceSectionDto> _adviceSectionService;
        private IFormSectionService<AgentSection, AgentSectionDto> _agentSectionService;
        private IFormSectionService<ApplicantSection, ApplicantSectionDto> _applicantSectionService;
        private IFormSectionService<AuthorityMemberSection, AuthorityMemberSectionDto> _authorityMemberSectionService;
        private IFormSectionService<BiodiversitySection, BiodiversitySectionDto> _biodiversitySectionService;
        private IFormSectionService<ConditionProposalSection, ConditionProposalSectionDto> _conditionProposalSectionService;
        private IFormSectionService<DischargeConditionSection, DischargeConditionSectionDto> _dischargeConditionSectionService;
        private IFormSectionService<EligibilitySection, EligibilitySectionDto> _eligibilitySectionService;
        private IFormSectionService<EmploymentSection, EmploymentSectionDto> _employmentSectionService;
        private IFormSectionService<ExistingUseSection, ExistingUseSectionDto> _existingUseSectionService;
        private IFormSectionService<FloodRiskSection, FloodRiskSectionDto> _floodRiskSectionService;
        private IFormSectionService<FloorSpaceSection, FloorSpaceSectionDto> _floorSpaceSectionService;
        private IFormSectionService<FoulSewageSection, FoulSewageSectionDto> _foulSewageSectionService;
        private IFormSectionService<HazardousSubstanceSection, HazardousSubstanceSectionDto> _hazardousSubstanceSectionService;
        private IFormSectionService<IndustrialMachinerySection, IndustrialMachinerySectionDto> _industrialMachinerySectionService;
        private IFormSectionService<MaterialSection, MaterialSectionDto> _materialSectionService;
        private IFormSectionService<NonMaterialProposalSection, NonMaterialProposalSectionDto> _nonMaterialProposalSectionService;
        private IFormSectionService<NonMaterialSoughtSection, NonMaterialSoughtSectionDto> _nonMaterialSoughtSectionService;
        private IFormSectionService<OpeningHoursSection, OpeningHoursSectionDto> _openingHoursSectionService;
        private IFormSectionService<OwnershipCertificationSection, OwnershipCertificationSectionDto> _ownershipCertificationSectionService;
        private IFormSectionService<ParkingSection, ParkingSectionDto> _parkingSectionService;
        private IFormSectionService<ProposalSection, ProposalSectionDto> _proposalSectionService;
        private IFormSectionService<ResidentialUnitsSection, ResidentialUnitsSectionDto> _residentialUnitsSectionService;
        private IFormSectionService<SiteSection, SiteSectionDto> _siteSectionService;
        private IFormSectionService<SiteVisitSection, SiteVisitSectionDto> _siteVisitSectionService;
        private IFormSectionService<TradeEffluentSection, TradeEffluentSectionDto> _tradeEffluentSectionService;
        private IFormSectionService<TreeAndHedgeSection, TreeAndHedgeSectionDto> _treeAndHedgeSectionService;
        private IFormSectionService<VariationConditionSection, VariationConditionSectionDto> _variationConditionSectionService;
        private IFormSectionService<WasteSection, WasteSectionDto> _wasteSectionService;

        public FormSectionServiceProvider(IMapper mapper)
        {
            _mapper = mapper;
        }

        public IFormSectionService<AccessSection, AccessSectionDto> AccessSectionService =>
            _accessSectionService ??= new FormSectionService<AccessSection, AccessSectionDto>(_mapper);

        public IFormSectionService<AdviceSection, AdviceSectionDto> AdviceSectionService =>
            _adviceSectionService ??= new FormSectionService<AdviceSection, AdviceSectionDto>(_mapper);

        public IFormSectionService<AgentSection, AgentSectionDto> AgentSectionService =>
            _agentSectionService ??= new FormSectionService<AgentSection, AgentSectionDto>(_mapper);

        public IFormSectionService<ApplicantSection, ApplicantSectionDto> ApplicantSectionService =>
            _applicantSectionService ??= new FormSectionService<ApplicantSection, ApplicantSectionDto>(_mapper);

        public IFormSectionService<AuthorityMemberSection, AuthorityMemberSectionDto> AuthorityMemberSectionService =>
            _authorityMemberSectionService ??= new FormSectionService<AuthorityMemberSection, AuthorityMemberSectionDto>(_mapper);

        public IFormSectionService<BiodiversitySection, BiodiversitySectionDto> BiodiversitySectionService =>
            _biodiversitySectionService ??= new FormSectionService<BiodiversitySection, BiodiversitySectionDto>(_mapper);

        public IFormSectionService<ConditionProposalSection, ConditionProposalSectionDto> ConditionProposalSectionService =>
            _conditionProposalSectionService ??= new FormSectionService<ConditionProposalSection, ConditionProposalSectionDto>(_mapper);

        public IFormSectionService<DischargeConditionSection, DischargeConditionSectionDto> DischargeConditionSectionService =>
            _dischargeConditionSectionService ??= new FormSectionService<DischargeConditionSection, DischargeConditionSectionDto>(_mapper);

        public IFormSectionService<EligibilitySection, EligibilitySectionDto> EligibilitySectionService =>
            _eligibilitySectionService ??= new FormSectionService<EligibilitySection, EligibilitySectionDto>(_mapper);

        public IFormSectionService<EmploymentSection, EmploymentSectionDto> EmploymentSectionService =>
            _employmentSectionService ??= new FormSectionService<EmploymentSection, EmploymentSectionDto>(_mapper);

        public IFormSectionService<ExistingUseSection, ExistingUseSectionDto> ExistingUseSectionService =>
            _existingUseSectionService ??= new FormSectionService<ExistingUseSection, ExistingUseSectionDto>(_mapper);

        public IFormSectionService<FloodRiskSection, FloodRiskSectionDto> FloodRiskSectionService =>
            _floodRiskSectionService ??= new FormSectionService<FloodRiskSection, FloodRiskSectionDto>(_mapper);

        public IFormSectionService<FloorSpaceSection, FloorSpaceSectionDto> FloorSpaceSectionService =>
            _floorSpaceSectionService ??= new FormSectionService<FloorSpaceSection, FloorSpaceSectionDto>(_mapper);

        public IFormSectionService<FoulSewageSection, FoulSewageSectionDto> FoulSewageSectionService =>
            _foulSewageSectionService ??= new FormSectionService<FoulSewageSection, FoulSewageSectionDto>(_mapper);

        public IFormSectionService<HazardousSubstanceSection, HazardousSubstanceSectionDto> HazardousSubstanceSectionService =>
            _hazardousSubstanceSectionService ??= new FormSectionService<HazardousSubstanceSection, HazardousSubstanceSectionDto>(_mapper);

        public IFormSectionService<IndustrialMachinerySection, IndustrialMachinerySectionDto> IndustrialMachinerySectionService =>
            _industrialMachinerySectionService ??= new FormSectionService<IndustrialMachinerySection, IndustrialMachinerySectionDto>(_mapper);

        public IFormSectionService<MaterialSection, MaterialSectionDto> MaterialSectionService =>
            _materialSectionService ??= new FormSectionService<MaterialSection, MaterialSectionDto>(_mapper);

        public IFormSectionService<NonMaterialProposalSection, NonMaterialProposalSectionDto> NonMaterialProposalSectionService =>
            _nonMaterialProposalSectionService ??= new FormSectionService<NonMaterialProposalSection, NonMaterialProposalSectionDto>(_mapper);

        public IFormSectionService<NonMaterialSoughtSection, NonMaterialSoughtSectionDto> NonMaterialSoughtSectionService =>
            _nonMaterialSoughtSectionService ??= new FormSectionService<NonMaterialSoughtSection, NonMaterialSoughtSectionDto>(_mapper);

        public IFormSectionService<OpeningHoursSection, OpeningHoursSectionDto> OpeningHoursSectionService =>
            _openingHoursSectionService ??= new FormSectionService<OpeningHoursSection, OpeningHoursSectionDto>(_mapper);

        public IFormSectionService<OwnershipCertificationSection, OwnershipCertificationSectionDto> OwnershipCertificationSectionService =>
            _ownershipCertificationSectionService ??= new FormSectionService<OwnershipCertificationSection, OwnershipCertificationSectionDto>(_mapper);

        public IFormSectionService<ParkingSection, ParkingSectionDto> ParkingSectionService =>
            _parkingSectionService ??= new FormSectionService<ParkingSection, ParkingSectionDto>(_mapper);

        public IFormSectionService<ProposalSection, ProposalSectionDto> ProposalSectionService =>
            _proposalSectionService ??= new FormSectionService<ProposalSection, ProposalSectionDto>(_mapper);

        public IFormSectionService<ResidentialUnitsSection, ResidentialUnitsSectionDto> ResidentialUnitsSectionService =>
            _residentialUnitsSectionService ??= new FormSectionService<ResidentialUnitsSection, ResidentialUnitsSectionDto>(_mapper);

        public IFormSectionService<SiteSection, SiteSectionDto> SiteSectionService =>
            _siteSectionService ??= new FormSectionService<SiteSection, SiteSectionDto>(_mapper);

        public IFormSectionService<SiteVisitSection, SiteVisitSectionDto> SiteVisitSectionService =>
            _siteVisitSectionService ??= new FormSectionService<SiteVisitSection, SiteVisitSectionDto>(_mapper);

        public IFormSectionService<TradeEffluentSection, TradeEffluentSectionDto> TradeEffluentSectionService =>
            _tradeEffluentSectionService ??= new FormSectionService<TradeEffluentSection, TradeEffluentSectionDto>(_mapper);

        public IFormSectionService<TreeAndHedgeSection, TreeAndHedgeSectionDto> TreeAndHedgeSectionService =>
            _treeAndHedgeSectionService ??= new FormSectionService<TreeAndHedgeSection, TreeAndHedgeSectionDto>(_mapper);

        public IFormSectionService<VariationConditionSection, VariationConditionSectionDto> VariationConditionSectionService =>
            _variationConditionSectionService ??= new FormSectionService<VariationConditionSection, VariationConditionSectionDto>(_mapper);

        public IFormSectionService<WasteSection, WasteSectionDto> WasteSectionService =>
            _wasteSectionService ??= new FormSectionService<WasteSection, WasteSectionDto>(_mapper);
    }
}
