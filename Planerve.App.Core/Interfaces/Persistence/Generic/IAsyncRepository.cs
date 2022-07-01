using Planerve.App.Core.Contracts.Specification;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Planerve.App.Core.Contracts.Persistence.Generic;

public interface IAsyncRepository<T> where T : class
{
    Task<T> GetByIdAsync(Guid id);
    Task<IReadOnlyList<T>> ListAllAsync();
    Task<T> AddAsync(T entity);
    Task DeleteAsync(T entity);
    Task UpdateAsync(T entity);
    IEnumerable<T> FindWithSpecificationPattern(ISpecification<T> specification = null);
}