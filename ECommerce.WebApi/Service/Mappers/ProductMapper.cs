using ECommerce.WebApi.Dtos.Products.Requests;
using ECommerce.WebApi.Models;

namespace ECommerce.WebApi.Service.Mappers;

public class ProductMapper
{
    public Product ConvertToEntity(CreateProductRequest request)
    {
        return new Product
        {
            Name = request.Name,
            Stock = request.Stock,
            Price = request.Price,
            CategoryId = request.CategoryId
        };
    }
}
