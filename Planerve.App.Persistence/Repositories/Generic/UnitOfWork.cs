using Planerve.App.Core.Interfaces.Persistence.Generic;
using Planerve.App.Domain.Entities.ApplicationEntities;
using Planerve.App.Domain.Entities.FormEntities;
using Planerve.App.Domain.Entities.FormEntities.Shared;
using Planerve.App.Persistence.Contexts;

namespace Planerve.App.Persistence.Repositories.Generic;

public class UnitOfWork : IUnitOfWork
{
    private readonly PlanerveDbContext _context;

    private IAsyncRepository<Application> _applicationRepository;
    private IAsyncRepository<ApplicationPermission> _applicationUserRepository;
    private IAsyncRepository<ApplicationType> _applicationTypeRepository;
    private IAsyncRepository<FormTypeA> _formTypeARepository;
    private IAsyncRepository<FormTypeB> _formTypeBRepository;
    private IAsyncRepository<FormTypeC> _formTypeCRepository;
    private IAsyncRepository<FormTypeD> _formTypeDRepository;
    private IAsyncRepository<FormTypeE> _formTypeERepository;

    private IAsyncRepository<AccessSection> _accessSectionRepository;
    private IAsyncRepository<AdviceSection> _adviceSectionRepository;
    private IAsyncRepository<AgentSection> _agentSectionRepository;
    private IAsyncRepository<ApplicantSection> _applicantSectionRepository;
    private IAsyncRepository<AuthorityMemberSection> _authorityMemberSectionRepository;
    private IAsyncRepository<BiodiversitySection> _biodiversitySectionRepository; 
    private IAsyncRepository<ConditionProposalSection> _conditionProposalSectionRepository;
    private IAsyncRepository<DischargeConditionSection> _dischargeConditionSectionRepository;
    private IAsyncRepository<EligibilitySection> _eligibilitySectionRepository;
    private IAsyncRepository<EmploymentSection> _employmentSectionRepository;
    private IAsyncRepository<ExistingUseSection> _existingUseSectionRepository;
    private IAsyncRepository<FloodRiskSection> _floodRiskSectionRepository;
    private IAsyncRepository<FloorSpaceSection> _floorSpaceSectionRepository;
    private IAsyncRepository<FoulSewageSection> _foulSewageSectionRepository;
    private IAsyncRepository<HazardousSubstanceSection> _hazardousSubstanceSectionRepository;
    private IAsyncRepository<IndustrialMachinerySection> _industrialMachinerySectionRepository;
    private IAsyncRepository<MaterialSection> _materialSectionRepository;
    private IAsyncRepository<NonMaterialProposalSection> _nonMaterialProposalSectionRepository;
    private IAsyncRepository<NonMaterialSoughtSection> _nonMaterialSoughtSectionRepository;
    private IAsyncRepository<OpeningHoursSection> _openingHoursSectionRepository;
    private IAsyncRepository<OwnershipCertificationSection> _ownershipCertificationSectionRepository;
    private IAsyncRepository<ParkingSection> _parkingSectionRepository;
    private IAsyncRepository<ProposalSection> _proposalSectionRepository;
    private IAsyncRepository<ResidentialUnitsSection> _residentialUnitsSectionRepository;
    private IAsyncRepository<SiteSection> _siteSectionRepository;
    private IAsyncRepository<SiteVisitSection> _siteVisitSectionRepository;
    private IAsyncRepository<TradeEffluentSection> _tradeEffluentSectionRepository;
    private IAsyncRepository<TreeAndHedgeSection> _treeAndHedgeSectionRepository;
    private IAsyncRepository<VariationConditionSection> _variationConditionSectionRepository;
    private IAsyncRepository<WasteSection> _wasteSectionRepository;

    public UnitOfWork(PlanerveDbContext dbContext)
    {
        _context = dbContext;
    }

    public IAsyncRepository<Application> ApplicationRepository
    {
        get
        {
            return _applicationRepository ??= new BaseRepository<Application>(_context);
        }
    }

    public IAsyncRepository<ApplicationPermission> ApplicationUserRepository
    {
        get
        {
            return _applicationUserRepository ??= new BaseRepository<ApplicationPermission>(_context);
        }
    }

    public IAsyncRepository<ApplicationType> ApplicationTypeRepository
    {
        get
        {
            return _applicationTypeRepository ??= new BaseRepository<ApplicationType>(_context);
        }
    }

    public IAsyncRepository<FormTypeA> FormTypeARepository
    {
        get
        {
            return _formTypeARepository ??= new BaseRepository<FormTypeA>(_context);
        }
    }

    public IAsyncRepository<FormTypeB> FormTypeBRepository
    {
        get
        {
            return _formTypeBRepository ??= new BaseRepository<FormTypeB>(_context);
        }
    }

    public IAsyncRepository<FormTypeC> FormTypeCRepository
    {
        get
        {
            return _formTypeCRepository ??= new BaseRepository<FormTypeC>(_context);
        }
    }

    public IAsyncRepository<FormTypeD> FormTypeDRepository
    {
        get
        {
            return _formTypeDRepository ??= new BaseRepository<FormTypeD>(_context);
        }
    }

    public IAsyncRepository<FormTypeE> FormTypeERepository
    {
        get
        {
            return _formTypeERepository ??= new BaseRepository<FormTypeE>(_context);
        }
    }

    public IAsyncRepository<AccessSection> AccessSectionRepository
    {
        get
        {
            return _accessSectionRepository ??= new BaseRepository<AccessSection>(_context);
        }
    }

    public IAsyncRepository<AdviceSection> AdviceSectionRepository
    {
        get
        {
            return _adviceSectionRepository ??= new BaseRepository<AdviceSection>(_context);
        }
    }

    public IAsyncRepository<AgentSection> AgentSectionRepository
    {
        get
        {
            return _agentSectionRepository ??= new BaseRepository<AgentSection>(_context);
        }
    }

    public IAsyncRepository<ApplicantSection> ApplicantSectionRepository
    {
        get
        {
            return _applicantSectionRepository ??= new BaseRepository<ApplicantSection>(_context);
        }
    }

    public IAsyncRepository<AuthorityMemberSection> AuthorityMemberSectionRepository
    {
        get
        {
            return _authorityMemberSectionRepository ??= new BaseRepository<AuthorityMemberSection>(_context);
        }
    }

    public IAsyncRepository<BiodiversitySection> BiodiversitySectionRepository
    {
        get
        {
            return _biodiversitySectionRepository ??= new BaseRepository<BiodiversitySection>(_context);
        }
    }

    public IAsyncRepository<ConditionProposalSection> ConditionProposalSectionRepository
    {
        get
        {
            return _conditionProposalSectionRepository ??= new BaseRepository<ConditionProposalSection>(_context);
        }
    }

    public IAsyncRepository<DischargeConditionSection> DischargeConditionSectionRepository
    {
        get
        {
            return _dischargeConditionSectionRepository ??= new BaseRepository<DischargeConditionSection>(_context);
        }
    }

    public IAsyncRepository<EligibilitySection> EligibilitySectionRepository
    {
        get
        {
            return _eligibilitySectionRepository ??= new BaseRepository<EligibilitySection>(_context);
        }
    }

    public IAsyncRepository<EmploymentSection> EmploymentSectionRepository
    {
        get
        {
            return _employmentSectionRepository ??= new BaseRepository<EmploymentSection>(_context);
        }
    }

    public IAsyncRepository<ExistingUseSection> ExistingUseSectionRepository
    {
        get
        {
            return _existingUseSectionRepository ??= new BaseRepository<ExistingUseSection>(_context);
        }
    }

    public IAsyncRepository<FloodRiskSection> FloodRiskSectionRepository
    {
        get
        {
            return _floodRiskSectionRepository ??= new BaseRepository<FloodRiskSection>(_context);
        }
    }

    public IAsyncRepository<FloorSpaceSection> FloorSpaceSectionRepository
    {
        get
        {
            return _floorSpaceSectionRepository ??= new BaseRepository<FloorSpaceSection>(_context);
        }
    }

    public IAsyncRepository<FoulSewageSection> FoulSewageSectionRepository
    {
        get
        {
            return _foulSewageSectionRepository ??= new BaseRepository<FoulSewageSection>(_context);
        }
    }

    public IAsyncRepository<HazardousSubstanceSection> HazardousSubstanceSectionRepository
    {
        get
        {
            return _hazardousSubstanceSectionRepository ??= new BaseRepository<HazardousSubstanceSection>(_context);
        }
    }

    public IAsyncRepository<IndustrialMachinerySection> IndustrialMachinerySectionRepository
    {
        get
        {
            return _industrialMachinerySectionRepository ??= new BaseRepository<IndustrialMachinerySection>(_context);
        }
    }

    public IAsyncRepository<MaterialSection> MaterialSectionRepository
    {
        get
        {
            return _materialSectionRepository ??= new BaseRepository<MaterialSection>(_context);
        }
    }

    public IAsyncRepository<NonMaterialProposalSection> NonMaterialProposalSectionRepository
    {
        get
        {
            return _nonMaterialProposalSectionRepository ??= new BaseRepository<NonMaterialProposalSection>(_context);
        }
    }

    public IAsyncRepository<NonMaterialSoughtSection> NonMaterialSoughtSectionRepository
    {
        get
        {
            return _nonMaterialSoughtSectionRepository ??= new BaseRepository<NonMaterialSoughtSection>(_context);
        }
    }

    public IAsyncRepository<OpeningHoursSection> OpeningHoursSectionRepository
    {
        get
        {
            return _openingHoursSectionRepository ??= new BaseRepository<OpeningHoursSection>(_context);
        }
    }

    public IAsyncRepository<OwnershipCertificationSection> OwnershipCertificationSectionRepository
    {
        get
        {
            return _ownershipCertificationSectionRepository ??= new BaseRepository<OwnershipCertificationSection>(_context);
        }
    }

    public IAsyncRepository<ParkingSection> ParkingSectionRepository
    {
        get
        {
            return _parkingSectionRepository ??= new BaseRepository<ParkingSection>(_context);
        }
    }

    public IAsyncRepository<ProposalSection> ProposalSectionRepository
    {
        get
        {
            return _proposalSectionRepository ??= new BaseRepository<ProposalSection>(_context);
        }
    }

    public IAsyncRepository<ResidentialUnitsSection> ResidentialUnitsSectionRepository
    {
        get
        {
            return _residentialUnitsSectionRepository ??= new BaseRepository<ResidentialUnitsSection>(_context);
        }
    }

    public IAsyncRepository<SiteSection> SiteSectionRepository
    {
        get
        {
            return _siteSectionRepository ??= new BaseRepository<SiteSection>(_context);
        }
    }

    public IAsyncRepository<SiteVisitSection> SiteVisitSectionRepository
    {
        get
        {
            return _siteVisitSectionRepository ??= new BaseRepository<SiteVisitSection>(_context);
        }
    }

    public IAsyncRepository<TradeEffluentSection> TradeEffluentSectionRepository
    {
        get
        {
            return _tradeEffluentSectionRepository ??= new BaseRepository<TradeEffluentSection>(_context);
        }
    }

    public IAsyncRepository<TreeAndHedgeSection> TreeAndHedgeSectionRepository
    {
        get
        {
            return _treeAndHedgeSectionRepository ??= new BaseRepository<TreeAndHedgeSection>(_context);
        }
    }

    public IAsyncRepository<VariationConditionSection> VariationConditionSectionRepository
    {
        get
        {
            return _variationConditionSectionRepository ??= new BaseRepository<VariationConditionSection>(_context);
        }
    }

    public IAsyncRepository<WasteSection> WasteSectionRepository
    {
        get
        {
            return _wasteSectionRepository ??= new BaseRepository<WasteSection>(_context);
        }
    }
}
