using Contracts;
using LoggerService;
using Repository;

namespace CompanyEmployees.Extensions;

/// <summary>
/// Service Extensions.
/// </summary>
public static class ServiceExtensions
{
    /// <summary>
    /// Configure CORS.
    /// </summary>
    /// <param name="services"></param>
    public static void ConfigureCors(this IServiceCollection services) =>
        services.AddCors(options =>
        {
            options.AddPolicy("CorsPolicy", builder =>
                builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader());
        });

    /// <summary>
    /// Configure IIS integration.
    /// </summary>
    /// <param name="services"></param>
    public static void ConfigureIISIntegration(this IServiceCollection services) =>
        services.Configure<IISOptions>(options =>
        {
        });

    /// <summary>
    /// Configure logger service.
    /// </summary>
    /// <param name="services"></param>
    public static void ConfigureLoggerService(this IServiceCollection services) =>
        services.AddSingleton<ILoggerManager, LoggerManager>();

    /// <summary>
    /// Configure repository manager.
    /// </summary>
    /// <param name="services"></param>
    public static void ConfigureRepositoryManager(this IServiceCollection services) =>
        services.AddScoped<IRepositoryManager, RepositoryManager>();
}