using Ecommerce.Entities;

namespace Ecommerce.Repository.Interfaces;

public interface IProductRepository
{
    public void AddProduct (Product product);
    public Product? GetProductByName(Product name);
}