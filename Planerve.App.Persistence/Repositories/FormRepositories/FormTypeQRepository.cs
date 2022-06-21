using Planerve.App.Core.Contracts.Persistence.FormInterfaces;
using Planerve.App.Domain.Entities.FormEntities;
using Planerve.App.Persistence.Contexts;

namespace Planerve.App.Persistence.Repositories.FormRepositories
{
    public class FormTypeQRepository : BaseRepository<FormTypeQ>, IFormTypeQRepository
    {
        public FormTypeQRepository(PlanerveDbContext dbContext) : base(dbContext)
        {

        }
    }
}
