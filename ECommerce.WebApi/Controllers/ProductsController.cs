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
        List<Product> products = _productService.GetAll();
        return Ok(products);
    }

    [HttpPost("add")]
    public IActionResult Add([FromBody]Product product)
    {
        var created = _productService.Add(product);
        return Ok(created);
    }

}
