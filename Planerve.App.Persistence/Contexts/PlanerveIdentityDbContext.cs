using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Planerve.App.Persistence.Contexts
{
    public class PlanerveIdentityDbContext : IdentityDbContext
    {
        public PlanerveIdentityDbContext(DbContextOptions<PlanerveIdentityDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
