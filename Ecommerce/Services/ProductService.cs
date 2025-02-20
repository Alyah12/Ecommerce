using Ecommerce.Context;
using Ecommerce.Model;
using Ecommerce.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Services;

public class ProductService : IProductService
{

    public readonly AppDbContext? _context;

    public void AddProduct(Product product) =>
        _context?.Product.AddAsync(product);


    public Product? GetProductByName(Product name) =>
        _context?.Product.FirstOrDefaultAsync(p => p.Id.Equals(name)).Result;
}