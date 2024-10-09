using ECommerce.WebApi.Models;
using ECommerce.WebApi.Repository.Abstracts;
using ECommerce.WebApi.Repository.Concretes;
using ECommerce.WebApi.Service.Abstracts;

namespace ECommerce.WebApi.Service.Concretes;

public class ProductService : IProductService
{

    private IProductRepository _productRepository;
    public ProductService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }


    public Product Add(Product product)
    {
        Product added = _productRepository.Add(product);

        return added;
    }

    public Product? Delete(int id)
    {
        Product product = _productRepository.Delete(id);

        return product;
    }

    public List<Product> GetAll()
    {
        return _productRepository.GetAll();
    }

    public Product? GetById(int id)
    {
        Product product = _productRepository.GetById(id);
        return product;
    }

    public Product Update(Product product)
    {
        Product updated = _productRepository.Update(product);
        return updated;
    }
}
