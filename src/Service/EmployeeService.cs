using Contracts;
using LoggerService;
using Service.Contracts;

namespace Service;

internal sealed class EmployeeService : IEmployeeService
{
    private readonly IRepositoryManager _repository;
    private readonly ILoggerManager _logger;

    public EmployeeService(IRepositoryManager repository, ILoggerManager logger)
    {
        this._repository = repository;
        this._logger = logger;
    }
}