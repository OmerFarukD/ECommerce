using ECommerce.WebApi.Models;

namespace ECommerce.WebApi.Repository.Abstracts;

public interface IProductRepository
{
    List<Product> GetAll();
    Product? GetById(int id);

    Product Add(Product product);
    Product Update(Product product);

    Product? Delete(int id);
}
