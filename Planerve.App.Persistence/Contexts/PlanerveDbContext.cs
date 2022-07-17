using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Planerve.App.Core.Interfaces.Services;
using Planerve.App.Domain.Common;
using Planerve.App.Domain.Entities.ApplicationEntities;
using Planerve.App.Domain.Entities.AuthEntities;
using Planerve.App.Domain.Entities.FormEntities;
using Planerve.App.Domain.Entities.FormEntities.Shared;
using System.Threading;
using System.Threading.Tasks;

namespace Planerve.App.Persistence.Contexts
{
    public class PlanerveDbContext : IdentityDbContext<ApplicationUser>
    {
        private readonly IUserService _userService;
        private readonly IDateTimeService _dateTimeService;

        public PlanerveDbContext(DbContextOptions<PlanerveDbContext> options, IUserService userService, IDateTimeService dateTimeService) : base(options)
        {
            _userService = userService;
            _dateTimeService = dateTimeService;
        }

        public DbSet<Application> Application { get; set; }
        public DbSet<FormTypeA> FormTypeA { get; set; }
        public DbSet<FormTypeB> FormTypeB { get; set; }
        public DbSet<FormTypeC> FormTypeC { get; set; }
        public DbSet<FormTypeD> FormTypeD { get; set; }
        public DbSet<FormTypeE> FormTypeE { get; set; }

        public DbSet<AccessSection> AccessSection {get; set;}
        public DbSet<AdviceSection> AdviceSection {get; set;}
        public DbSet<AgentSection> AgentSection {get; set;}
        public DbSet<ApplicantSection> ApplicantSection {get; set;}
        public DbSet<AuthorityMemberSection> AuthorityMemberSection {get; set;}
        public DbSet<BiodiversitySection> BiodiversitySection {get; set;}
        public DbSet<ConditionProposalSection> ConditionProposalSection {get; set;}
        public DbSet<DischargeConditionSection> DischargeConditionSection {get; set;}
        public DbSet<EligibilitySection> EligibilitySection {get; set;}
        public DbSet<EmploymentSection> EmploymentSection {get; set;}
        public DbSet<ExistingUseSection> ExistingUseSection {get; set;}
        public DbSet<FloodRiskSection> FloodRiskSection {get; set;}
        public DbSet<FloorSpaceSection> FloorSpaceSection {get; set;}
        public DbSet<FoulSewageSection> FoulSewageSection {get; set;}
        public DbSet<HazardousSubstanceSection> HazardousSubstanceSection {get; set;}
        public DbSet<IndustrialMachinerySection> IndustrialMachinerySection {get; set;}
        public DbSet<MaterialSection> MaterialSection {get; set;}
        public DbSet<NonMaterialProposalSection> NonMaterialProposalSection {get; set;}
        public DbSet<NonMaterialSoughtSection> NonMaterialSoughtSection {get; set;}
        public DbSet<OpeningHoursSection> OpeningHoursSection {get; set;}
        public DbSet<OwnershipCertificationSection> OwnershipCertificationSection {get; set;}
        public DbSet<ParkingSection> ParkingSection {get; set;}
        public DbSet<ProposalSection> ProposalSection {get; set;}
        public DbSet<ResidentialUnitsSection> ResidentialUnitsSection {get; set;}
        public DbSet<SiteSection> SiteSection {get; set;}
        public DbSet<SiteVisitSection> SiteVisitSection {get; set;}
        public DbSet<TradeEffluentSection> TradeEffluentSection {get; set;}
        public DbSet<TreeAndHedgeSection> TreeAndHedgeSection {get; set;}
        public DbSet<VariationConditionSection> VariationConditionSection {get; set;}
        public DbSet<WasteSection> WasteSection {get; set;}

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedDate = _dateTimeService.UtcNow;
                        entry.Entity.Owner = _userService.UserId();
                        break;
                    case EntityState.Modified:
                        entry.Entity.LastModifiedDate = _dateTimeService.UtcNow;
                        entry.Entity.LastModifiedBy = _userService.UserId();
                        break;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<MaterialSection>()
                .OwnsMany(t => t.MaterialTypes);

            modelBuilder.Entity<EligibilitySection>()
                .OwnsMany(t => t.NotifiedPeople);

            modelBuilder.Entity<HazardousSubstanceSection>()
                .OwnsMany(t => t.Substances);

            modelBuilder.Entity<IndustrialMachinerySection>()
                .OwnsMany(t => t.WasteManagementDetails);

            modelBuilder.Entity<IndustrialMachinerySection>()
                .OwnsMany(t => t.WasteStreamDetails);

            modelBuilder.Entity<OpeningHoursSection>()
            .OwnsMany(t => t.UseClasses);

            modelBuilder.Entity<OwnershipCertificationSection>()
                .OwnsOne(x => x.CertificateA);

            modelBuilder.Entity<OwnershipCertificationSection>()
                .OwnsOne(x => x.CertificateB);

            modelBuilder.Entity<OwnershipCertificationSection>()
                .OwnsOne(x => x.CertificateC);

            modelBuilder.Entity<OwnershipCertificationSection>()
                .OwnsOne(x => x.CertificateD);

            modelBuilder.Entity<OwnershipCertificationSection>()
                .OwnsMany(x => x.Persons);

            modelBuilder.Entity<FloorSpaceSection>()
                    .OwnsMany(x => x.FloorSpaces);

            modelBuilder.Entity<FloorSpaceSection>()
                    .OwnsMany(x => x.RoomInformations);
        }
    }
}
