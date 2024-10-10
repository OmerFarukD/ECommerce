using ECommerce.WebApi.Dtos.Products.Requests;
using ECommerce.WebApi.Dtos.Products.Responses;
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


    public ProductResponseDto ConvertToResponse(Product product)
    {
        return new ProductResponseDto(
            Id:product.Id,
            Name:product.Name,
            Stock:product.Stock,
            Price: product.Price,
            CategoryName: product.Category.Name
            );
    }

    public List<ProductResponseDto> ConvertToResponseList(List<Product> products)
    {
        return products.Select(x => ConvertToResponse(x)).ToList();
    }
}
