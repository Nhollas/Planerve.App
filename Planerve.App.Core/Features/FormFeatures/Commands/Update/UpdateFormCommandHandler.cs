using MediatR;
using Microsoft.AspNetCore.Authorization;
using Planerve.App.Core.Authorization.Requirements;
using Planerve.App.Core.Exceptions;
using Planerve.App.Core.Features.FormFeatures.Actions;
using Planerve.App.Core.Interfaces.Persistence.Generic;
using Planerve.App.Core.Interfaces.Services;
using Planerve.App.Domain.Entities.ApplicationEntities;
using Planerve.App.Domain.Entities.FormEntities;
using Planerve.App.Domain.Entities.FormEntities.Shared;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Planerve.App.Core.Features.FormFeatures.Commands.Update
{
    public class UpdateFormCommandHandler : IRequestHandler<UpdateFormCommand>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAuthorizationService _authorizationService;
        private readonly IUserService _userService;
        private readonly IFormSectionServiceProvider _formSectionServiceProvider;

        public UpdateFormCommandHandler(
            IUnitOfWork unitOfWork,
            IAuthorizationService authorizationService,
            IUserService userService,
            IFormSectionServiceProvider formSectionServiceProvider)
        {
            _unitOfWork = unitOfWork;
            _authorizationService = authorizationService;
            _userService = userService;
            _formSectionServiceProvider = formSectionServiceProvider;
        }
        public async Task<Unit> Handle(UpdateFormCommand request, CancellationToken cancellation)
        {
            var user = await _userService.GetUser();

            ApplicationPermission authorisedUsers = await _unitOfWork.ApplicationUserRepository.GetByIdAsync(request.Id);

            var authorisedResult = await _authorizationService.AuthorizeAsync(user, authorisedUsers, FormPolicies.UpdateForm);

            // If check fails this user doesn't have permissions to update this form, throw NotAuthorisedException.
            if (!authorisedResult.Succeeded)
            {
                throw new NotAuthorisedException(nameof(FormTypeA), user.Identity.Name);
            }

            await UpdateForm(request);

            return Unit.Value;
        }

        public async Task UpdateForm(UpdateFormCommand request)
        {
            ApplicationType type = await _unitOfWork.ApplicationTypeRepository.GetByIdAsync(request.Id);

            // Check if the section route is valid based on the form type.
            object sectionType = IsValidRoute(request.Section, type.Value);

            if (sectionType == null)
            {
                throw new NotFoundException(request.Section, type);
            }

            /// <summary>
            /// Handle the form section service based on it's type.
            /// I was unable to use a generic UpdateSection class as the each update class has it's specific requirements. 
            /// So I settled for a generic service instead.
            /// </summary>
            switch (sectionType)
            {
                case AccessSection:
                    await new UpdateAccessSection(_formSectionServiceProvider.AccessSectionService, _unitOfWork.AccessSectionRepository)
                        .Update(request.Data, request.Id);
                    break;
                case AdviceSection:
                    await new UpdateAdviceSection(_formSectionServiceProvider.AdviceSectionService, _unitOfWork.AdviceSectionRepository)
                        .Update(request.Data, request.Id);
                    break;
                case AgentSection:
                    await new UpdateAgentSection(_formSectionServiceProvider.AgentSectionService, _unitOfWork.AgentSectionRepository)
                        .Update(request.Data, request.Id);
                    break;
                case ApplicantSection:
                    await new UpdateApplicantSection(_formSectionServiceProvider.ApplicantSectionService, _unitOfWork.ApplicantSectionRepository)
                        .Update(request.Data, request.Id);
                    break;
                case AuthorityMemberSection:
                    await new UpdateAuthorityMemberSection(_formSectionServiceProvider.AuthorityMemberSectionService, _unitOfWork.AuthorityMemberSectionRepository)
                        .Update(request.Data, request.Id);
                    break;
                case BiodiversitySection:
                    await new UpdateBiodiversitySection(_formSectionServiceProvider.BiodiversitySectionService, _unitOfWork.BiodiversitySectionRepository)
                        .Update(request.Data, request.Id);
                    break;
                case ConditionProposalSection:
                    await new UpdateConditionProposalSection(_formSectionServiceProvider.ConditionProposalSectionService, _unitOfWork.ConditionProposalSectionRepository)
                        .Update(request.Data, request.Id);
                    break;
                case DischargeConditionSection:
                    await new UpdateDischargeConditionSection(_formSectionServiceProvider.DischargeConditionSectionService, _unitOfWork.DischargeConditionSectionRepository)
                        .Update(request.Data, request.Id);
                    break;
                case EligibilitySection:
                    await new UpdateEligibilitySection(_formSectionServiceProvider.EligibilitySectionService, _unitOfWork.EligibilitySectionRepository)
                        .Update(request.Data, request.Id);
                    break;
                case EmploymentSection:
                    await new UpdateEmploymentSection(_formSectionServiceProvider.EmploymentSectionService, _unitOfWork.EmploymentSectionRepository)
                        .Update(request.Data, request.Id);
                    break;
                case ExistingUseSection:
                    await new UpdateExistingUseSection(_formSectionServiceProvider.ExistingUseSectionService, _unitOfWork.ExistingUseSectionRepository)
                        .Update(request.Data, request.Id);
                    break;
                case FloodRiskSection:
                    await new UpdateFloodRiskSection(_formSectionServiceProvider.FloodRiskSectionService, _unitOfWork.FloodRiskSectionRepository)
                        .Update(request.Data, request.Id);
                    break;
                case FloorSpaceSection:
                    await new UpdateFloorSpaceSection(_formSectionServiceProvider.FloorSpaceSectionService, _unitOfWork.FloorSpaceSectionRepository)
                        .Update(request.Data, request.Id);
                    break;
                case FoulSewageSection:
                    await new UpdateFoulSewageSection(_formSectionServiceProvider.FoulSewageSectionService, _unitOfWork.FoulSewageSectionRepository)
                        .Update(request.Data, request.Id);
                    break;
                case HazardousSubstanceSection:
                    await new UpdateHazardousSubstanceSection(_formSectionServiceProvider.HazardousSubstanceSectionService, _unitOfWork.HazardousSubstanceSectionRepository)
                        .Update(request.Data, request.Id);
                    break;
                case IndustrialMachinerySection:
                    await new UpdateIndustrialMachinerySection(_formSectionServiceProvider.IndustrialMachinerySectionService, _unitOfWork.IndustrialMachinerySectionRepository)
                        .Update(request.Data, request.Id);
                    break;
                case MaterialSection:
                    await new UpdateMaterialSection(_formSectionServiceProvider.MaterialSectionService, _unitOfWork.MaterialSectionRepository)
                        .Update(request.Data, request.Id);
                    break;
                case NonMaterialProposalSection:
                    await new UpdateNonMaterialProposalSection(_formSectionServiceProvider.NonMaterialProposalSectionService, _unitOfWork.NonMaterialProposalSectionRepository)
                        .Update(request.Data, request.Id);
                    break;
                case NonMaterialSoughtSection:
                    await new UpdateNonMaterialSoughtSection(_formSectionServiceProvider.NonMaterialSoughtSectionService, _unitOfWork.NonMaterialSoughtSectionRepository)
                        .Update(request.Data, request.Id);
                    break;
                case OpeningHoursSection:
                    await new UpdateOpeningHoursSection(_formSectionServiceProvider.OpeningHoursSectionService, _unitOfWork.OpeningHoursSectionRepository)
                        .Update(request.Data, request.Id);
                    break;
                case OwnershipCertificationSection:
                    await new UpdateOwnershipCertificationSection(_formSectionServiceProvider.OwnershipCertificationSectionService, _unitOfWork.OwnershipCertificationSectionRepository)
                        .Update(request.Data, request.Id);
                    break;
                case ParkingSection:
                    await new UpdateParkingSection(_formSectionServiceProvider.ParkingSectionService, _unitOfWork.ParkingSectionRepository)
                        .Update(request.Data, request.Id);
                    break;
                case ProposalSection:
                    await new UpdateProposalSection(_formSectionServiceProvider.ProposalSectionService, _unitOfWork.ProposalSectionRepository)
                        .Update(request.Data, request.Id);
                    break;
                case ResidentialUnitsSection:
                    await new UpdateResidentialUnitsSection(_formSectionServiceProvider.ResidentialUnitsSectionService, _unitOfWork.ResidentialUnitsSectionRepository)
                        .Update(request.Data, request.Id);
                    break;
                case SiteSection:
                    await new UpdateSiteSection(_formSectionServiceProvider.SiteSectionService, _unitOfWork.SiteSectionRepository)
                        .Update(request.Data, request.Id);
                    break;
                case SiteVisitSection:
                    await new UpdateSiteVisitSection(_formSectionServiceProvider.SiteVisitSectionService, _unitOfWork.SiteVisitSectionRepository)
                        .Update(request.Data, request.Id);
                    break;
                case TradeEffluentSection:
                    await new UpdateTradeEffluentSection(_formSectionServiceProvider.TradeEffluentSectionService, _unitOfWork.TradeEffluentSectionRepository)
                        .Update(request.Data, request.Id);
                    break;
                case TreeAndHedgeSection:
                    await new UpdateTreeAndHedgeSection(_formSectionServiceProvider.TreeAndHedgeSectionService, _unitOfWork.TreeAndHedgeSectionRepository)
                        .Update(request.Data, request.Id);
                    break;
                case VariationConditionSection:
                    await new UpdateVariationConditionSection(_formSectionServiceProvider.VariationConditionSectionService, _unitOfWork.VariationConditionSectionRepository)
                        .Update(request.Data, request.Id);
                    break;
                case WasteSection:
                    await new UpdateWasteSection(_formSectionServiceProvider.WasteSectionService, _unitOfWork.WasteSectionRepository)
                        .Update(request.Data, request.Id);
                    break;
            }
        }

        /// <summary>
        /// A form type comes from when the application is created. In this case it can be a range from 1-5 of the different types.
        /// The sectionName is pulled from the endpoint route and chucked into the dictionary below.
        /// The dictionary checks based on the type that the form section they are trying to update is possible.
        /// An example of this is that formType 1 cannot update a FloodRiskSection, it's a formType 2 only section.
        /// </summary>
        public static object IsValidRoute(string sectionName, int formType)
        {
            var typeData = new Dictionary<int, Dictionary<string, object>>
            {
                {   1,
                    new Dictionary<string, object>
                    {
                        {"site", new SiteSection() },
                        {"applicant", new ApplicantSection() },
                        {"agent", new AgentSection() },
                        {"proposal", new ProposalSection() },
                        {"material", new MaterialSection() },
                        {"treeandhedge", new TreeAndHedgeSection() },
                        {"access", new AccessSection() },
                        {"parking", new ParkingSection() },
                        {"sitevisit", new SiteVisitSection() },
                        {"advice", new AdviceSection() },
                        {"authoritymember", new AuthorityMemberSection() },
                        {"ownershipcertificate", new OwnershipCertificationSection() },
                    }
                },
                {   2,
                    new Dictionary<string, object>
                    {
                        {"site", new SiteSection() },
                        {"applicant", new ApplicantSection() },
                        {"agent", new AgentSection() },
                        {"proposal", new ProposalSection() },
                        {"existinguse", new ExistingUseSection() },
                        {"material", new MaterialSection() },
                        {"access", new AccessSection() },
                        {"parking", new ParkingSection() },
                        {"treeandhedge", new TreeAndHedgeSection() },
                        {"floodrisk", new FloodRiskSection() },
                        {"foulsewage", new FoulSewageSection() },
                        {"waste", new WasteSection() },
                        {"tradeeffluent", new TradeEffluentSection() },
                        {"residentialunits", new ResidentialUnitsSection() },
                        {"floorspace", new FloorSpaceSection() },
                        {"employment", new EmploymentSection() },
                        {"openinghours", new OpeningHoursSection() },
                        {"industrialmachinery", new IndustrialMachinerySection() },
                        {"hazardoussubstance", new HazardousSubstanceSection() },
                        {"sitevisit", new SiteVisitSection() },
                        {"advice", new AdviceSection() },
                        {"authoritymember", new AuthorityMemberSection() },
                        {"ownershipcertificate", new OwnershipCertificationSection() },
                    }
                },
                {   3,
                    new Dictionary<string, object>
                    {
                        {"site", new SiteSection() },
                        {"applicant", new ApplicantSection() },
                        {"agent", new AgentSection() },
                        {"conditionproposal", new ConditionProposalSection() },
                        {"dischargecondition", new DischargeConditionSection() },
                        {"sitevisit", new SiteVisitSection() },
                        {"advice", new AdviceSection() }
                    }
                },
                {   4,
                    new Dictionary<string, object>
                    {
                        {"site", new SiteSection() },
                        {"applicant", new ApplicantSection() },
                        {"agent", new AgentSection() },
                        {"eligibility", new EligibilitySection() },
                        {"nonmaterialproposal", new NonMaterialProposalSection() },
                        {"nonmaterialsought", new NonMaterialSoughtSection() },
                        {"sitevisit", new SiteVisitSection() },
                        {"advice", new AdviceSection() },
                        {"authoritymember", new AuthorityMemberSection() }
                    }
                },
                {   5,
                    new Dictionary<string, object>
                    {
                        {"site", new SiteSection() },
                        {"applicant", new ApplicantSection() },
                        {"agent", new AgentSection() },
                        {"conditionproposal", new ConditionProposalSection() },
                        {"variationcondition", new VariationConditionSection() },
                        {"sitevisit", new SiteVisitSection() },
                        {"advice", new AdviceSection() },
                        {"ownershipcertificate", new OwnershipCertificationSection() }
                    }
                },
            };

            typeData.TryGetValue(formType, out var sectionData);
            sectionData.TryGetValue(sectionName, out var sectionType);

            return sectionType;
        }
    }
}
