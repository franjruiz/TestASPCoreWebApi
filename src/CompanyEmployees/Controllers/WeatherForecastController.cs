using LoggerService;
using Microsoft.AspNetCore.Mvc;

namespace CompanyEmployees.Controllers
{
    /// <summary>
    /// WeatherForecastController
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILoggerManager _logger;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="logger"></param>
        public WeatherForecastController(ILoggerManager logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Get
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            this._logger.LogInfo("Here is info message from our values controller.");
            this._logger.LogDebug("Here is debug message from our values controller.");
            this._logger.LogWarn("Here is warn message from our values controller.");
            this._logger.LogError("Here is error message from our values controller.");

            return new string[] { "value1", "value2" };
        }
    }
}