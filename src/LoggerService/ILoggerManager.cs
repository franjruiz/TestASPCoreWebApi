namespace LoggerService;

/// <summary>
/// Logger Manager Interface.
/// </summary>
public interface ILoggerManager
{
    /// <summary>
    /// Log Info.
    /// </summary>
    /// <param name="message"></param>
    void LogInfo(string message);

    /// <summary>
    /// Log Warning.
    /// </summary>
    /// <param name="message"></param>
    void LogWarn(string message);

    /// <summary>
    /// Log Debug.
    /// </summary>
    /// <param name="message"></param>
    void LogDebug(string message);

    /// <summary>
    /// Log Error.
    /// </summary>
    /// <param name="message"></param>
    void LogError(string message);
}