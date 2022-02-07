using Planerve.App.Domain.Entities.ApplicationEntities;
using System;
using System.Threading.Tasks;

namespace Planerve.App.Core.Contracts.Persistence;

public interface IApplicationDataRepository : IAsyncRepository<Application>
{
    Task<bool> IsAppReferenceNameUnique(string name);

    Task<Application> GetApplicationById(Guid id);
}