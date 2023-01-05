using Contracts;
using Entities.Models;

namespace Repository;

/// <summary>
/// Company repository
/// </summary>
public class CompanyRepository : RepositoryBase<Company>, ICompanyRepository
{
    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="repositoryContext"></param>
    public CompanyRepository(RepositoryContext repositoryContext)
        : base(repositoryContext)
    {
    }
}