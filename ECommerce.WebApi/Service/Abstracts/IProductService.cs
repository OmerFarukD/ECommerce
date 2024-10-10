using ECommerce.WebApi.Dtos.Products.Requests;
using ECommerce.WebApi.Models;

namespace ECommerce.WebApi.Service.Abstracts;

public interface IProductService
{
    List<Product> GetAll();
    Product? GetById(int id);

    Product Add(CreateProductRequest product);
    Product Update(Product product);

    Product? Delete(int id);
}
