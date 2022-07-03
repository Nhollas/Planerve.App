using Microsoft.EntityFrameworkCore;
using Planerve.App.Core.Contracts.Specification;
using System.Linq;

namespace Planerve.App.Persistence.Repositories.Generic;

public static class SpecificationEvaluator<TEntity> where TEntity : class
{
    public static IQueryable<TEntity> GetQuery(IQueryable<TEntity> inputQuery, ISpecification<TEntity> spec)
    {
        var query = inputQuery;
        if (spec.Criteria != null)
        {
            query = query.Where(spec.Criteria);
        }
        if (spec.OrderBy != null)
        {
            query = query.OrderBy(spec.OrderBy);
        }
        if (spec.OrderByDescending != null)
        {
            query = query.OrderByDescending(spec.OrderByDescending);
        }
        query = spec.Includes.Aggregate(query, (current, include) => current.Include(include));
        return query;
    }
}
