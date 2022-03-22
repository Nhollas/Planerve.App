using Microsoft.EntityFrameworkCore;
using Planerve.App.Core.Contracts.Persistence;
using Planerve.App.Domain.Entities.ApplicationEntities;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Planerve.App.Persistence.Repositories
{
    public class ApplicationDataRepository : BaseRepository<Application>, IApplicationDataRepository
    {
        public ApplicationDataRepository(PlanerveDbContext dbContext) : base(dbContext)
        {

        }

        public Task<bool> IsAppReferenceNameUnique(string name)
        {
            var matches = _dbContext.Application.Any(e => e.ApplicationReference.Equals(name));
            return Task.FromResult(matches);
        }
    }
}