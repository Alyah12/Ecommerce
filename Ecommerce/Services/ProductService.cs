using Ecommerce.Context;
using Ecommerce.Model;
using Ecommerce.Repository.Interfaces;
using Ecommerce.Services.Interfaces;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Services;

public class ProductService : IProductService
{

    public readonly AppDbContext _context;

    public void AddProduct(Product product) =>
        _context.Product.AddAsync(product);


    public Product? GetProductById(Product name) =>
        _context.Product.FirstOrDefaultAsync(p => p.Id.Equals(name)).Result;
}