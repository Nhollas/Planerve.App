using Microsoft.EntityFrameworkCore;
using Planerve.App.Core.Services;
using Planerve.App.Domain.Common;
using Planerve.App.Domain.Entities.ApplicationEntities;
using Planerve.App.Domain.Entities.FormEntities;
using System.Threading;
using System.Threading.Tasks;

namespace Planerve.App.Persistence.Contexts;

public class PlanerveDbContext : DbContext
{
    private readonly IUserService _userService;
    private readonly IDateTimeService _dateTimeService;
    public PlanerveDbContext(DbContextOptions<PlanerveDbContext> options)
        : base(options)
    {
    }

    public PlanerveDbContext(DbContextOptions<PlanerveDbContext> options, IUserService userService, IDateTimeService dateTimeService)
    : base(options)
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

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
    {
        foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
        {
            switch (entry.State)
            {
                case EntityState.Added:
                    entry.Entity.CreatedDate = _dateTimeService.UtcNow;
                    entry.Entity.CreatedBy = _userService.UserId();
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
        modelBuilder.Entity<ApplicationDocument>()
            .OwnsMany(t => t.DocumentRequirements);


        modelBuilder.Entity<FormTypeA>()
            .OwnsOne(t => t.ApplicantSection);
        modelBuilder.Entity<FormTypeA>()
            .OwnsOne(t => t.AgentSection);
        modelBuilder.Entity<FormTypeA>()
            .OwnsOne(t => t.ProposalSection);
        modelBuilder.Entity<FormTypeA>()
            .OwnsOne(t => t.SiteSection);
        modelBuilder.Entity<FormTypeA>()
            .OwnsOne(t => t.AccessSection);
        modelBuilder.Entity<FormTypeA>()
            .OwnsOne(t => t.AdviceSection);
        modelBuilder.Entity<FormTypeA>()
            .OwnsOne(t => t.TreeAndHedgeSection);
        modelBuilder.Entity<FormTypeA>()
            .OwnsOne(t => t.ParkingSection);
        modelBuilder.Entity<FormTypeA>()
            .OwnsOne(t => t.AuthorityMemberSection);
        modelBuilder.Entity<FormTypeA>()
            .OwnsOne(t => t.MaterialSection);
        modelBuilder.Entity<FormTypeA>()
            .OwnsOne(t => t.OwnershipCertificationSection);
        modelBuilder.Entity<FormTypeA>()
            .OwnsOne(t => t.SiteVisitSection);


        modelBuilder.Entity<FormTypeB>()
            .OwnsOne(t => t.ApplicantSection);
        modelBuilder.Entity<FormTypeB>()
            .OwnsOne(t => t.AgentSection);
        modelBuilder.Entity<FormTypeB>()
            .OwnsOne(t => t.ProposalSection);
        modelBuilder.Entity<FormTypeB>()
            .OwnsOne(t => t.SiteSection);
        modelBuilder.Entity<FormTypeB>()
            .OwnsOne(t => t.AdviceSection);
        modelBuilder.Entity<FormTypeB>()
            .OwnsOne(t => t.AccessSection);
        modelBuilder.Entity<FormTypeB>()
            .OwnsOne(t => t.WasteSection);
        modelBuilder.Entity<FormTypeB>()
            .OwnsOne(t => t.AuthorityMemberSection);
        modelBuilder.Entity<FormTypeB>()
            .OwnsOne(t => t.MaterialSection);
        modelBuilder.Entity<FormTypeB>()
            .OwnsOne(t => t.ParkingSection);
        modelBuilder.Entity<FormTypeB>()
            .OwnsOne(t => t.FloodRiskSection);
        modelBuilder.Entity<FormTypeB>()
            .OwnsOne(t => t.FoulSewageSection);
        modelBuilder.Entity<FormTypeB>()
            .OwnsOne(t => t.BiodiversitySection);
        modelBuilder.Entity<FormTypeB>()
            .OwnsOne(t => t.ExistingUseSection);
        modelBuilder.Entity<FormTypeB>()
            .OwnsOne(t => t.TreeAndHedgeSection);
        modelBuilder.Entity<FormTypeB>()
            .OwnsOne(t => t.TradeEffluentSection);
        modelBuilder.Entity<FormTypeB>()
            .OwnsOne(t => t.EmploymentSection);
        modelBuilder.Entity<FormTypeB>()
            .OwnsOne(t => t.OpeningHoursSection);
        modelBuilder.Entity<FormTypeB>()
            .OwnsOne(t => t.SiteAreaSection);
        modelBuilder.Entity<FormTypeB>()
            .OwnsOne(t => t.IndustrialMachinerySection);
        modelBuilder.Entity<FormTypeB>()
            .OwnsOne(t => t.HazardousSubstancesSection);
        modelBuilder.Entity<FormTypeB>()
            .OwnsOne(t => t.OwnershipCertificationSection);
        modelBuilder.Entity<FormTypeB>()
            .OwnsOne(t => t.SiteVisitSection);


        modelBuilder.Entity<FormTypeC>()
            .OwnsOne(t => t.ApplicantSection);
        modelBuilder.Entity<FormTypeC>()
            .OwnsOne(t => t.AgentSection);
        modelBuilder.Entity<FormTypeC>()
            .OwnsOne(t => t.SiteSection);
        modelBuilder.Entity<FormTypeC>()
            .OwnsOne(t => t.AdviceSection);
        modelBuilder.Entity<FormTypeC>()
            .OwnsOne(t => t.ProposalSection);
        modelBuilder.Entity<FormTypeC>()
            .OwnsOne(t => t.SiteVisitSection);


        modelBuilder.Entity<FormTypeD>()
            .OwnsOne(t => t.ApplicantSection);
        modelBuilder.Entity<FormTypeD>()
            .OwnsOne(t => t.AgentSection);
        modelBuilder.Entity<FormTypeD>()
            .OwnsOne(t => t.SiteSection);
        modelBuilder.Entity<FormTypeD>()
            .OwnsOne(t => t.AdviceSection);
        modelBuilder.Entity<FormTypeD>()
            .OwnsOne(t => t.AuthorityMemberSection);
        modelBuilder.Entity<FormTypeD>()
            .OwnsOne(t => t.ProposalSection);
        modelBuilder.Entity<FormTypeD>()
            .OwnsOne(t => t.SiteVisitSection);


        modelBuilder.Entity<FormTypeE>()
            .OwnsOne(t => t.ApplicantSection);
        modelBuilder.Entity<FormTypeE>()
            .OwnsOne(t => t.AgentSection);
        modelBuilder.Entity<FormTypeE>()
            .OwnsOne(t => t.SiteSection);
        modelBuilder.Entity<FormTypeE>()
            .OwnsOne(t => t.AdviceSection);
        modelBuilder.Entity<FormTypeE>()
            .OwnsOne(t => t.ProposalSection);
        modelBuilder.Entity<FormTypeE>()
            .OwnsOne(t => t.OwnershipCertificationSection);
        modelBuilder.Entity<FormTypeE>()
            .OwnsOne(t => t.SiteVisitSection);
    }
}