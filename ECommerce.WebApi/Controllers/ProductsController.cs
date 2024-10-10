using ECommerce.WebApi.Dtos.Products.Requests;
using ECommerce.WebApi.Dtos.Products.Responses;
using ECommerce.WebApi.Models;
using ECommerce.WebApi.Service.Abstracts;
using Microsoft.AspNetCore.Mvc;
namespace ECommerce.WebApi.Controllers;

// @RestController
// @RequestMapping("api/products/")

[Route("api/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{
    private  IProductService _productService;

    public ProductsController(IProductService productService)
    {
        _productService = productService;
    }


    [HttpGet("getall")]
    public IActionResult GetAll()
    {
        List<ProductResponseDto> products = _productService.GetAll();
        return Ok(products);
    }

    [HttpPost("add")]
    public IActionResult Add([FromBody]CreateProductRequest product)
    {
        var created = _productService.Add(product);
        return Ok(created);
    }

    [HttpGet("{id:int}")]
    public IActionResult GetById([FromRoute]int id)
    {
        var product = _productService.GetById(id);
        return Ok(product);
    }

}
