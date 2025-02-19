using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Model;

public class Product
{
    public Guid? Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public decimal? Price { get; set; }
    public bool? Sale { get; set; }
}