using Microsoft.EntityFrameworkCore;
using Planerve.App.Core.Interfaces.Persistence.Generic;
using Planerve.App.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Planerve.App.Persistence.Repositories.Generic;

public class BaseRepository<T> : IAsyncRepository<T> where T : class
{
    protected PlanerveDbContext _dbContext;

    public BaseRepository(PlanerveDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public virtual async Task<T> GetByIdAsync(Guid id)
    {
        return await _dbContext.Set<T>().FindAsync(id);
    }

    public async Task<IReadOnlyList<T>> ListAllAsync()
    {
        return await _dbContext.Set<T>().ToListAsync();
    }

    public async Task<T> AddAsync(T entity)
    {
        await _dbContext.Set<T>().AddAsync(entity);
        await _dbContext.SaveChangesAsync();

        return entity;
    }

    public async Task DeleteAsync(T entity)
    {
        _dbContext.Set<T>().Remove(entity);
        await _dbContext.SaveChangesAsync();
    }

    public async Task UpdateAsync(T entity)
    {
        _dbContext.Entry(entity);
        await _dbContext.SaveChangesAsync();
    }

    public IEnumerable<T> FindWithSpecificationPattern(ISpecification<T> specification = null)
    {
        return SpecificationEvaluator<T>.GetQuery(_dbContext.Set<T>().AsQueryable(), specification);
    }
}