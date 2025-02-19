using Ecommerce.Context;
using Ecommerce.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Controllers;

[ApiController]
[Route("api/[controller]")]

public class ProductController
{
    public readonly AppDbContext _context;

    public ProductController(AppDbContext context)
    {
        _context = context;
    }
}