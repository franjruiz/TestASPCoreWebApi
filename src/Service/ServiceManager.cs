using Contracts;
using LoggerService;
using Service.Contracts;

namespace Service;

/// <summary>
/// Service manager
/// </summary>
public sealed class ServiceManager : IServiceManager
{
    private readonly Lazy<ICompanyService> _companyService;
    private readonly Lazy<IEmployeeService> _employeeService;

    /// <summary>
    /// Constructor
    /// </summary>
    public ServiceManager(IRepositoryManager repositoryManager, ILoggerManager logger)
    {
        this._companyService = new Lazy<ICompanyService>(() => new CompanyService(repositoryManager, logger));
        this._employeeService = new Lazy<IEmployeeService>(() => new EmployeeService(repositoryManager, logger));
    }

    /// <inheritdoc/>
    public ICompanyService CompanyService => this._companyService.Value;

    /// <inheritdoc/>
    public IEmployeeService EmployeeService => this._employeeService.Value;
}