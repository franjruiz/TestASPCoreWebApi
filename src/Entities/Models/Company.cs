using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models;

/// <summary>
/// Company
/// </summary>
public class Company
{
    /// <summary>
    /// Id
    /// </summary>
    [Column("CompanyId")]
    public Guid Id { get; set; }

    /// <summary>
    /// Name
    /// </summary>
    [Required(ErrorMessage = "Company name is a required field.")]
    [MaxLength(60, ErrorMessage = "Maximum length for the name is 60 characters.")]
    public string? Name { get; set; }

    /// <summary>
    /// Address
    /// </summary>
    [Required(ErrorMessage = "Company address is a required field.")]
    [MaxLength(60, ErrorMessage = "Maximum length for the address is 60 characters.")]
    public string? Address { get; set; }

    /// <summary>
    /// Country
    /// </summary>
    public string? Country { get; set; }

    /// <summary>
    /// Employees
    /// </summary>
    public ICollection<Employee>? Employees { get; set; }
}
