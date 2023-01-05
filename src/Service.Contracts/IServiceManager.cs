namespace Service.Contracts;

/// <summary>
/// Service manager interface
/// </summary>
public interface IServiceManager
{
    /// <summary>
    /// Company service
    /// </summary>
    ICompanyService CompanyService { get; }

    /// <summary>
    /// Employee service
    /// </summary>
    IEmployeeService EmployeeService { get; }
}