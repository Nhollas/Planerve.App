using Microsoft.EntityFrameworkCore;
using Planerve.App.Core.Contracts.Identity;
using Planerve.App.Domain.Common;
using Planerve.App.Domain.Entities.ApplicationEntities;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Planerve.App.Persistence;

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
    public DbSet<Form> FormData { get; set; }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
    {
        foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
        {
            switch (entry.State)
            {
                case EntityState.Added:
                    entry.Entity.CreatedDate = DateTime.Now;
                    entry.Entity.CreatedBy = _loggedInUserService.UserId;
                    break;
                case EntityState.Modified:
                    entry.Entity.LastModifiedDate = DateTime.Now;
                    entry.Entity.LastModifiedBy = _loggedInUserService.UserId;
                    break;
            }
        }
        return base.SaveChangesAsync(cancellationToken);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

    }
}