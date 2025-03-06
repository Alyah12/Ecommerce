using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Entities;

[Index(nameof(Email), IsUnique = true)]
public class User
{
    public Guid Id { get; set; }

    [StringLength(100)]
    public string? Name { get; set; }

    [Required]
    [EmailAddress]
    [StringLength(100)]

    public string? Email { get; set; }

    [StringLength(3)]
    [Required]
    public int Age { get; set; }

    [MinLength(8), MaxLength(20)]
    public string? Password { get; set; }

    [StringLength(20)]
    public string? Role { get; set; }
}