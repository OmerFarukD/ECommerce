using ECommerce.WebApi.Dtos.Products.Requests;
using ECommerce.WebApi.Models;
using ECommerce.WebApi.Repository.Abstracts;
using ECommerce.WebApi.Repository.Concretes;
using ECommerce.WebApi.Service.Abstracts;
using ECommerce.WebApi.Service.Mappers;

namespace ECommerce.WebApi.Service.Concretes;

public class ProductService : IProductService
{

    private IProductRepository _productRepository;
    private ProductMapper _productMapper;
    public ProductService(IProductRepository productRepository,ProductMapper mapper)
    {
        _productRepository = productRepository;
        _productMapper = mapper;
    }


    public Product Add(CreateProductRequest dto)
    {

        Product product = _productMapper.ConvertToEntity(dto);

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
