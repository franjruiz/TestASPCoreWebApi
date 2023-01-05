using Contracts;

namespace Repository;

/// <summary>
/// Repository manager
/// </summary>
public sealed class RepositoryManager : IRepositoryManager
{
    private readonly RepositoryContext _repositoryContext;
    private readonly Lazy<ICompanyRepository> _companyRepository;
    private readonly Lazy<IEmployeeRepository> _employeeRepository;

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="repositoryContext"></param>
    public RepositoryManager(RepositoryContext repositoryContext)
    {
        this._repositoryContext = repositoryContext;
        this._companyRepository = new Lazy<ICompanyRepository>(() => new CompanyRepository(repositoryContext));
        this._employeeRepository = new Lazy<IEmployeeRepository>(() => new EmployeeRepository(repositoryContext));
    }

    /// <inheritdoc/>
    public ICompanyRepository Company => this._companyRepository.Value;

    /// <inheritdoc/>
    public IEmployeeRepository Employee => this._employeeRepository.Value;

    /// <inheritdoc/>
    public void Save() => this._repositoryContext.SaveChanges();
}