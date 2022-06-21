using Microsoft.EntityFrameworkCore;
using Planerve.App.Core.Contracts.Persistence;
using Planerve.App.Core.Contracts.Specification;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Planerve.App.Persistence.Contexts;

namespace Planerve.App.Persistence.Repositories;

public class BaseRepository<TEntity> : IAsyncRepository<TEntity> where TEntity : class
{
    protected readonly PlanerveDbContext _dbContext;

    public BaseRepository(PlanerveDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public virtual async Task<TEntity> GetByIdAsync(Guid id)
    {
        return await _dbContext.Set<TEntity>().FindAsync(id);
    }

    public async Task<IReadOnlyList<TEntity>> ListAllAsync()
    {
        return await _dbContext.Set<TEntity>().ToListAsync();
    }

    public async Task<TEntity> AddAsync(TEntity entity)
    {
        await _dbContext.Set<TEntity>().AddAsync(entity);
        await _dbContext.SaveChangesAsync();

        return entity;
    }

    public async Task DeleteAsync(TEntity entity)
    {
        _dbContext.Set<TEntity>().Remove(entity);
        await _dbContext.SaveChangesAsync();
    }

    public async Task UpdateAsync(TEntity entity)
    {
        _dbContext.Entry(entity);
        await _dbContext.SaveChangesAsync();
    }

    public IEnumerable<TEntity> FindWithSpecificationPattern(ISpecification<TEntity> specification = null)
    {
        return SpecificationEvaluator<TEntity>.GetQuery(_dbContext.Set<TEntity>().AsQueryable(), specification);
    }
}