using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Entities;

public class Product
{
    public Guid? Id { get; set; }

    [StringLength(100)]
    public string? Name { get; set; }
    [StringLength(100)]
    public string? Description { get; set; }
    public decimal? Price { get; set; }
    public bool? Sale { get; set; }
}