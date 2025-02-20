using Ecommerce.Context;
using Ecommerce.DTO;
using Ecommerce.Model;
using Ecommerce.Services;
using Ecommerce.Services.Interfaces;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Controllers;

[ApiController]
[Route("api/[controller]")]

public class ProductController
{
    public readonly IProductService _productService;

    public ProductController(IProductService productService)
    {
        _productService = productService;
    }

    [HttpGet("name")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public ActionResult <Product> GetProductById(Product name)
    {
        return _productService?.GetProductByName(name);
    }

    [HttpPost(nameof(AddProduct))]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public void AddProduct(Product product)
    {
        _productService.AddProduct(product);
    }
}