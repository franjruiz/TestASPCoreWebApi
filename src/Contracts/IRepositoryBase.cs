using System.Linq.Expressions;

namespace Contracts;

/// <summary>
/// Repository base interface
/// </summary>
/// <typeparam name="T"></typeparam>
public interface IRepositoryBase<T>
{
    /// <summary>
    /// Find all
    /// </summary>
    /// <param name="trackChanges"></param>
    /// <returns></returns>
    IQueryable<T> FindAll(bool trackChanges);

    /// <summary>
    /// Find by condition
    /// </summary>
    /// <param name="expression"></param>
    /// <param name="trackChanges"></param>
    /// <returns></returns>
    IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges);

    /// <summary>
    /// Create
    /// </summary>
    /// <param name="entity"></param>
    void Create(T entity);

    /// <summary>
    /// Update
    /// </summary>
    /// <param name="entity"></param>
    void Update(T entity);

    /// <summary>
    /// Delete
    /// </summary>
    /// <param name="entity"></param>
    void Delete(T entity);
}