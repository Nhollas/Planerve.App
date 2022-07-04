using FluentValidation;

namespace Planerve.App.Core.Features.FormFeatures.Commands.UpdateFormTypeA
{
    public class UpdateFormTypeACommandValidator : AbstractValidator<UpdateFormTypeACommand>
    {
        public UpdateFormTypeACommandValidator()
        {
            RuleFor(e => e.SiteSection.Description)
                .NotEmpty().WithMessage("{PropertyName} is required when a postcode is not known.")
                .When(x => x.SiteSection.Postcode.Length == 0);
            RuleFor(e => e.ApplicantSection.LastName)
                .NotEmpty().WithMessage("{PropertyName} is required.");
            RuleFor(e => e.ApplicantSection.AddressLineOne)
                .NotEmpty().WithMessage("{PropertyName} is required.");
            RuleFor(e => e.AgentSection.LastName)
                .NotEmpty().WithMessage("{PropertyName} is required.");
            RuleFor(e => e.AgentSection.AddressLineOne)
                .NotEmpty().WithMessage("{PropertyName} is required.");
            RuleFor(e => e.AgentSection.Phone)
                .NotEmpty().WithMessage("{PropertyName} is required.");
            RuleFor(e => e.AgentSection.Email)
                .NotEmpty().WithMessage("{PropertyName} is required.");
            RuleFor(e => e.ProposalSection.Description)
                .NotEmpty().WithMessage("{PropertyName} is required.");
            RuleFor(e => e.ProposalSection.StartDate)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .When(x => x.ProposalSection.HasStarted == true);
            RuleFor(e => e.MaterialSection.MaterialTypes)
                .NotEmpty().WithMessage("Please provide a description of existing and proposed materials and finishes to be used externally (including type, colour and name for each material).")
                .When(x => x.MaterialSection.MaterialsRequired == true);
            RuleFor(e => e.MaterialSection.DocumentReference)
                .NotEmpty().WithMessage("Please state references for the plans, drawings and/or design and access statement is required.")
                .When(x => x.MaterialSection.AdditionalInformation == true);
            RuleFor(e => e.TreeAndHedgeSection.TreeHedgeRemovedReference)
                .NotEmpty().WithMessage("Please mark their position on a scaled plan and state the reference number of any plans or drawings.")
                .When(x => x.TreeAndHedgeSection.TreeHedgeRemoved == true);
            RuleFor(e => e.TreeAndHedgeSection.FallingTreeHedgeReference)
                .NotEmpty().WithMessage("please show on the plans, indicating the scale, which trees by giving them numbers (e.g. T1, T2 etc) and state the reference number of any plans or drawings.")
                .When(x => x.TreeAndHedgeSection.FallingTreesHedge == true);
            RuleFor(e => e.AccessSection.DrawingReferenceNumbers)
                .NotEmpty().WithMessage("If Yes to any questions, please show details on your plans or drawings and state their reference numbers.")
                .When(x => x.AccessSection.NewVehicleAccess == true || x.AccessSection.NewAlteredPedestrianAccess == true || x.AccessSection.AffectingRightOfWay == true);
            RuleFor(e => e.ParkingSection.ParkingDescription)
                .NotEmpty().WithMessage("A description of the parking is required.")
                .When(x => x.ParkingSection.AffectingParking == true);
            When(x => x.SiteVisitSection.AppointmentContactType == 3, () => {
                RuleFor(x => x.SiteVisitSection.FirstName).NotEmpty().WithMessage("{PropertyName} is required.");
                RuleFor(x => x.SiteVisitSection.LastName).NotEmpty().WithMessage("{PropertyName} is required.");
                RuleFor(x => x.SiteVisitSection.Phone).NotEmpty().WithMessage("{PropertyName} is required.");
                RuleFor(x => x.SiteVisitSection.Email).NotEmpty().WithMessage("{PropertyName} is required.");
            });
            When(x => x.AdviceSection.AdviceSought == true, () => {
                RuleFor(x => x.AdviceSection.ContactFirstName).NotEmpty().WithMessage("{PropertyName} is required.");
                RuleFor(x => x.AdviceSection.ContactLastName).NotEmpty().WithMessage("{PropertyName} is required.");
                RuleFor(x => x.AdviceSection.Date).NotEmpty().WithMessage("{PropertyName} is required.");
                RuleFor(x => x.AdviceSection.AdviceDescription).NotEmpty().WithMessage("{PropertyName} is required.");
            });
            RuleFor(x => x.AuthorityMemberSection.RelatedInformation).NotEmpty().WithMessage("{PropertyName} is required.")
                .When(x => x.AuthorityMemberSection.IsRelated == true);

            RuleFor(x => x.OwnershipCertificationSection.CertificateA).NotEmpty().WithMessage("{PropertyName} is required.")
                .When(x => x.OwnershipCertificationSection.SoleOwner == true && x.OwnershipCertificationSection.IsAgriculturalHolding == false);
            RuleFor(x => x.OwnershipCertificationSection.CertificateB).NotEmpty().WithMessage("{PropertyName} is required.")
                .When(x => x.OwnershipCertificationSection.SoleOwner == true && x.OwnershipCertificationSection.IsAgriculturalHolding == true && x.OwnershipCertificationSection.GiveAppropriateNotice == true);
            RuleFor(x => x.OwnershipCertificationSection.CertificateC).NotEmpty().WithMessage("{PropertyName} is required.")
                .When(x => x.OwnershipCertificationSection.SoleOwner == true && x.OwnershipCertificationSection.IsAgriculturalHolding == true && x.OwnershipCertificationSection.GiveAppropriateNotice == false && x.OwnershipCertificationSection.GiveSomeNotice == true);
            RuleFor(x => x.OwnershipCertificationSection.CertificateD).NotEmpty().WithMessage("{PropertyName} is required.")
                .When(x => x.OwnershipCertificationSection.SoleOwner == true && x.OwnershipCertificationSection.IsAgriculturalHolding == true && x.OwnershipCertificationSection.GiveAppropriateNotice == false && x.OwnershipCertificationSection.GiveSomeNotice == false);
        }
    }
}
