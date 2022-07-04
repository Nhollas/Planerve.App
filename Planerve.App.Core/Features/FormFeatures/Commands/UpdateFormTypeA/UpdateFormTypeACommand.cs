using System;
using MediatR;
using Planerve.App.Core.Features.FormFeatures.Dtos;

namespace Planerve.App.Core.Features.FormFeatures.Commands.UpdateFormTypeA
{
    public class UpdateFormTypeACommand : IRequest
    {
        public Guid Id { get; set; }
        public ApplicantSectionDto ApplicantSection { get; set; }
        public AgentSectionDto AgentSection { get; set; }
        public ProposalSectionDto ProposalSection { get; set; }
        public SiteSectionDto SiteSection { get; set; }
        public AccessSectionDto AccessSection { get; set; }
        public AdviceSectionDto AdviceSection { get; set; }
        public TreeAndHedgeSectionDto TreeAndHedgeSection { get; set; }
        public ParkingSectionDto ParkingSection { get; set; }
        public AuthorityMemberSectionDto AuthorityMemberSection { get; set; }
        public MaterialSectionDto MaterialSection { get; set; }
        public OwnershipCertificationSectionDto OwnershipCertificationSection { get; set; }
        public SiteVisitSectionDto SiteVisitSection { get; set; }
    }
}
