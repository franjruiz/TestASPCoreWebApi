﻿namespace CompanyEmployees.Extensions;

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
}