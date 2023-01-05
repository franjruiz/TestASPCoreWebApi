using System.Linq.Expressions;
using Contracts;
using Microsoft.EntityFrameworkCore;

namespace Repository;

/// <summary>
/// Repository base
/// </summary>
/// <typeparam name="T"></typeparam>
public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
{
    /// <summary>
    /// Repository context.
    /// </summary>
    protected RepositoryContext RepositoryContext;

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="repositoryContext"></param>
    protected RepositoryBase(RepositoryContext repositoryContext)
    {
        this.RepositoryContext = repositoryContext;
    }

    /// <inheritdoc/>
    public void Create(T entity) => this.RepositoryContext.Set<T>().Add(entity);

    /// <inheritdoc/>
    public void Delete(T entity) => this.RepositoryContext.Set<T>().Remove(entity);

    /// <inheritdoc/>
    public IQueryable<T> FindAll(bool trackChanges)
    {
        if (!trackChanges)
        {
            return this.RepositoryContext.Set<T>().AsNoTracking();
        }

        return this.RepositoryContext.Set<T>();
    }

    /// <inheritdoc/>
    public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges)
    {
        if (!trackChanges)
        {
            return this.RepositoryContext.Set<T>().Where(expression).AsNoTracking();
        }

        return this.RepositoryContext.Set<T>().Where(expression);
    }

    /// <inheritdoc/>
    public void Update(T entity) => this.RepositoryContext.Set<T>().Update(entity);
}