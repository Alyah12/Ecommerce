﻿using Ecommerce.Model;

namespace Ecommerce.Services.Interfaces;

public interface IProductService
{
    public void AddProduct(Product product);
    public Product? GetProductByName(Product name);
}