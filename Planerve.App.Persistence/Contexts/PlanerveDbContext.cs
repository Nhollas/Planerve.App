using Microsoft.EntityFrameworkCore;
using Planerve.App.Core.Contracts.Identity;
using Planerve.App.Domain.Common;
using Planerve.App.Domain.Entities.ApplicationEntities;
using Planerve.App.Domain.Entities.FormEntities;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Planerve.App.Persistence.Contexts;

public class PlanerveDbContext : DbContext
{
    private readonly ILoggedInUserService _loggedInUserService;
    public PlanerveDbContext(DbContextOptions<PlanerveDbContext> options)
        : base(options)
    {
    }

    public PlanerveDbContext(DbContextOptions<PlanerveDbContext> options, ILoggedInUserService loggedInUserService)
    : base(options)
    {
        _loggedInUserService = loggedInUserService;
    }

    public DbSet<Application> Application { get; set; }
    public DbSet<FormTypeA> FormTypeA { get; set; }
    public DbSet<FormTypeB> FormTypeB { get; set; }
    public DbSet<FormTypeC> FormTypeC { get; set; }
    public DbSet<FormTypeD> FormTypeD { get; set; }
    public DbSet<FormTypeE> FormTypeE { get; set; }
    public DbSet<FormTypeF> FormTypeF { get; set; }
    public DbSet<FormTypeG> FormTypeG { get; set; }
    public DbSet<FormTypeH> FormTypeH { get; set; }
    public DbSet<FormTypeI> FormTypeI { get; set; }
    public DbSet<FormTypeJ> FormTypeJ { get; set; }
    public DbSet<FormTypeK> FormTypeK { get; set; }
    public DbSet<FormTypeL> FormTypeL { get; set; }
    public DbSet<FormTypeM> FormTypeM { get; set; }
    public DbSet<FormTypeN> FormTypeN { get; set; }
    public DbSet<FormTypeO> FormTypeO { get; set; }
    public DbSet<FormTypeP> FormTypeP { get; set; }
    public DbSet<FormTypeQ> FormTypeQ { get; set; }
    public DbSet<FormTypeR> FormTypeR { get; set; }
    public DbSet<FormTypeS> FormTypeS { get; set; }
    public DbSet<FormTypeT> FormTypeT { get; set; }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
    {
        foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
        {
            switch (entry.State)
            {
                case EntityState.Added:
                    entry.Entity.CreatedDate = DateTime.Now;
                    break;
                case EntityState.Modified:
                    entry.Entity.LastModifiedDate = DateTime.Now;
                    entry.Entity.LastModifiedBy = _loggedInUserService.UserId().Result;
                    break;
            }
        }
        return base.SaveChangesAsync(cancellationToken);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ApplicationDocument>()
            .OwnsMany(t => t.DocumentRequirements);
    }
}