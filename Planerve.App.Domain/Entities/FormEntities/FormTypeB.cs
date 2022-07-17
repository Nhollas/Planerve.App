using Planerve.App.Domain.Common;
using Planerve.App.Domain.Entities.FormEntities.Shared;
using System;
using System.ComponentModel.DataAnnotations;

namespace Planerve.App.Domain.Entities.FormEntities
{
    // Full Planning Permission
    public class FormTypeB : AuditableEntity
    {
        public void Initialize(Guid formId)
        {
            FormId = formId;
            SiteSection = new SiteSection() { Id = formId };
            ApplicantSection = new ApplicantSection() { Id = formId };
            AgentSection = new AgentSection() { Id = formId };
            ProposalSection = new ProposalSection() { Id = formId };
            ExistingUseSection = new ExistingUseSection() { Id = formId };
            MaterialSection = new MaterialSection() { Id = formId };
            AccessSection = new AccessSection() { Id = formId };
            ParkingSection = new ParkingSection() { Id = formId };
            TreeAndHedgeSection = new TreeAndHedgeSection() { Id = formId };
            FloodRiskSection = new FloodRiskSection() { Id = formId };
            BiodiversitySection = new BiodiversitySection() { Id = formId };
            FoulSewageSection = new FoulSewageSection() { Id = formId };
            WasteSection = new WasteSection() { Id = formId };
            TradeEffluentSection = new TradeEffluentSection() { Id = formId };
            ResidentialUnitsSection = new ResidentialUnitsSection() { Id = formId };
            FloorSpaceSection = new FloorSpaceSection() { Id = formId };
            EmploymentSection = new EmploymentSection() { Id = formId };
            OpeningHoursSection = new OpeningHoursSection() { Id = formId };
            IndustrialMachinerySection = new IndustrialMachinerySection() { Id = formId };
            HazardousSubstanceSection = new HazardousSubstanceSection() { Id = formId };
            SiteVisitSection = new SiteVisitSection() { Id = formId };
            AdviceSection = new AdviceSection() { Id = formId };
            AuthorityMemberSection = new AuthorityMemberSection() { Id = formId };
            OwnershipCertificationSection = new OwnershipCertificationSection() { Id = formId };
        }

        [Key]
        public Guid FormId { get; set; }
        public SiteSection SiteSection { get; set; }
        public ApplicantSection ApplicantSection { get; set; }
        public AgentSection AgentSection { get; set; }
        public ProposalSection ProposalSection { get; set; }
        public ExistingUseSection ExistingUseSection { get; set; }
        public MaterialSection MaterialSection { get; set; }
        public AccessSection AccessSection { get; set; }
        public ParkingSection ParkingSection { get; set; }
        public TreeAndHedgeSection TreeAndHedgeSection { get; set; }
        public FloodRiskSection FloodRiskSection { get; set; }
        public BiodiversitySection BiodiversitySection { get; set; }
        public FoulSewageSection FoulSewageSection { get; set; }
        public WasteSection WasteSection { get; set; }
        public TradeEffluentSection TradeEffluentSection { get; set; }
        public ResidentialUnitsSection ResidentialUnitsSection { get; set; }
        public FloorSpaceSection FloorSpaceSection { get; set; }
        public EmploymentSection EmploymentSection { get; set; }
        public OpeningHoursSection OpeningHoursSection { get; set; }
        public IndustrialMachinerySection IndustrialMachinerySection { get; set; }
        public HazardousSubstanceSection HazardousSubstanceSection { get; set; }
        public SiteVisitSection SiteVisitSection { get; set; }
        public AdviceSection AdviceSection { get; set; }
        public AuthorityMemberSection AuthorityMemberSection { get; set; }
        public OwnershipCertificationSection OwnershipCertificationSection { get; set; }
    }
}
