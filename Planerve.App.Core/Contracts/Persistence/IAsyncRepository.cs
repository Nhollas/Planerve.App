using Planerve.App.Core.Contracts.Specification;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Planerve.App.Core.Contracts.Persistence;

public interface IAsyncRepository<TEntity> where TEntity : class
{
    Task<TEntity> GetByIdAsync(Guid id);
    Task<IReadOnlyList<TEntity>> ListAllAsync();
    Task<TEntity> AddAsync(TEntity entity);
    Task DeleteAsync(TEntity entity);
    Task UpdateAsync(TEntity entity);
    IEnumerable<TEntity> FindWithSpecificationPattern(ISpecification<TEntity> specification = null);
}