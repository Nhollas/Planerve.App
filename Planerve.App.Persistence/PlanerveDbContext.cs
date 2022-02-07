using Microsoft.EntityFrameworkCore;
using Planerve.App.Domain.Entities.ApplicationEntities;
using System.Threading;
using System.Threading.Tasks;

namespace Planerve.App.Persistence;

public class PlanerveDbContext : DbContext
{
    public PlanerveDbContext(DbContextOptions<PlanerveDbContext> options)
        : base(options)
    {
    }

    public DbSet<Application> Application { get; set; }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new())
    {
        return base.SaveChangesAsync(cancellationToken);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
    }
}