using ECommerce.WebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.WebApi.Controllers;

// @RestController
// @RequestMapping("api/products/")

[Route("api/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{

    static List<Product> Products = new List<Product>()
    {
        new Product { Id = 1,Name = "Dyson Süpürge",Price=25000, Stock=50 },
        new Product { Id = 2,Name = "Iphone 16 Pro",Price=87000, Stock=100 },
        new Product { Id = 3,Name = "Steel Series Alpha 7",Price=25000, Stock=850 },
        new Product { Id = 4,Name = "Piyano Masası",Price=99999, Stock=1 },
        new Product { Id = 5,Name = "Lisanslı fb forması",Price=5000, Stock=5000 },


    };


    [HttpGet]
    public List<Product> GetAll()
    {
        return Products;
    }

    [HttpGet("getbyid")]  
    public Product GetById([FromQuery] int id)
    {
        Product product = Products.SingleOrDefault(x=> x.Id==id);
        return product;
    }


}
