using NLog;

namespace LoggerService
{
    /// <summary>
    /// Logger Manager.
    /// </summary>
    public class LoggerManager : ILoggerManager
    {
        private static readonly ILogger Logger = LogManager.GetCurrentClassLogger();

        /// <summary>
        /// Constructor.
        /// </summary>
        public LoggerManager()
        {
        }

        /// <inheritdoc/>
        public void LogDebug(string message) => Logger.Debug(message);

        /// <inheritdoc/>
        public void LogError(string message) => Logger.Error(message);

        /// <inheritdoc/>
        public void LogInfo(string message) => Logger.Info(message);

        /// <inheritdoc/>
        public void LogWarn(string message) => Logger.Warn(message);
    }
}