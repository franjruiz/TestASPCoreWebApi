using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repository.Configuration;

namespace Repository;

/// <summary>
/// Repository context.
/// </summary>
public class RepositoryContext : DbContext
{
    /// <summary>
    /// Constructor.
    /// </summary>
    /// <param name="options"></param>
    public RepositoryContext(DbContextOptions options)
        : base(options)
    {
    }

    /// <summary>
    /// Companies.
    /// </summary>
    public DbSet<Company>? Companies { get; set; }

    /// <summary>
    /// Employees
    /// </summary>
    public DbSet<Employee>? Employees { get; set; }

    /// <inheritdoc/>
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new CompanyConfiguration());
        modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
    }
}