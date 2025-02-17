using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Model;

public class User
{
    public Guid Id { get; set; }

    [StringLength(100)]
    public string? Name { get; set; }

    [StringLength(100)]
    public string? Email { get; set; }

    [MinLength(8), MaxLength(20)]
    public string? Password { get; set; }
    public string? Role { get; set; }
}