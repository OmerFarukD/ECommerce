using ECommerce.WebApi.Models;

namespace ECommerce.WebApi.Service.Abstracts;

public interface IProductService
{
    List<Product> GetAll();
    Product? GetById(int id);

    Product Add(Product product);
    Product Update(Product product);

    Product? Delete(int id);
}
