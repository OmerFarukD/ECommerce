namespace ECommerce.WebApi.Dtos.Products.Requests;

public record CreateProductRequest
    (
    string Name,
    int Stock,
    decimal Price,
    int CategoryId
    );
