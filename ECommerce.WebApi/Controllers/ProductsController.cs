using ECommerce.WebApi.Contexts;
using ECommerce.WebApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.WebApi.Controllers;

// @RestController
// @RequestMapping("api/products/")

[Route("api/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{

    MsSqlContext context = new MsSqlContext();


    [HttpPost("add")]

    public IActionResult Add([FromBody] Product product)
    {

        // insert into Products(kolonlar) values(değerler)
        context.Products.Add(product);
        context.SaveChanges();

        return Ok(product);
    }

    [HttpGet("getall")]
 
    public IActionResult GetAll()
    {
        // sELECT * FROM PRODUCTS
        return Ok(context.Products.ToList());
    }

    [HttpGet("{id}")]
    public IActionResult GetById([FromRoute]int id)
    {
        Product product = context.Products.SingleOrDefault(x=>x.Id==id);
        if (product is null)
        {
            return NotFound("Aradığınız ürün bulunamadı.");
        }

        return Ok(product);
    }

}
