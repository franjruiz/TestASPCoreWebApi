using Contracts;
using Entities.Models;

namespace Repository;

/// <summary>
/// Employee repository
/// </summary>
public class EmployeeRepository : RepositoryBase<Employee>, IEmployeeRepository
{
    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="repositoryContext"></param>
    public EmployeeRepository(RepositoryContext repositoryContext)
        : base(repositoryContext)
    {
    }
}