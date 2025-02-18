using Ecommerce.Context;
using Ecommerce.Model;
using Ecommerce.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Repository;

public class ProductRepository : IProductRepository
{
    readonly AppDbContext _context;

    public ProductRepository(AppDbContext context)
    {
        _context = context;
    }

    public void AddProduct (Product product) =>
        _context.Product.AddAsync(product);

    public Product? GetProductById(int id) =>
        _context.Product.FirstOrDefaultAsync(p => p.Id.Equals(id)).Result;
}