namespace Contracts;

/// <summary>
/// Repository manager interface
/// </summary>
public interface IRepositoryManager
{
    /// <summary>
    /// Company
    /// </summary>
    ICompanyRepository Company { get; }

    /// <summary>
    /// Employee
    /// </summary>
    IEmployeeRepository Employee { get; }

    /// <summary>
    /// Save
    /// </summary>
    void Save();
}