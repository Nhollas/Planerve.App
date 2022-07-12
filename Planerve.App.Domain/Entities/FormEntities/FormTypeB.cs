using Planerve.App.Domain.Common;
using Planerve.App.Domain.Entities.FormEntities.Shared;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Planerve.App.Domain.Entities.FormEntities
{
    // Full Planning Permission
    public class FormTypeB : AuditableEntity
    {
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
