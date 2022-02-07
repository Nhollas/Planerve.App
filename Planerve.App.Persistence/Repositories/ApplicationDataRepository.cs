using System;
using Planerve.App.Core.Contracts.Persistence;
using System.Threading.Tasks;
using System.Linq;
using Planerve.App.Domain.Entities.ApplicationEntities;
using Microsoft.EntityFrameworkCore;

namespace Planerve.App.Persistence.Repositories
{
    public class ApplicationDataRepository : BaseRepository<Application>, IApplicationDataRepository
    {
        public ApplicationDataRepository(PlanerveDbContext dbContext) : base(dbContext)
        {

        }

        public Task<bool> IsAppReferenceNameUnique(string name)
        {
            var matches = DbContext.Application.Any(e => e.ApplicationReference.Equals(name));
            return Task.FromResult(matches);
        }

        public async Task<Application> GetApplicationById(Guid id)
        {
            var application = await DbContext.Application
                .Include(n => n.ApplicationTypeOne)
                .Include(n => n.ApplicationTypeTwo)
                .Include(n => n.SiteApiData)
                    .ThenInclude(x => x.result)
                    .ThenInclude(x => x.codes)
                .FirstAsync(o => o.Id == id);

            return application;
        }
    }
}
