using EcommerceSiteAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace EcommerceSiteAPI.Controllers
{
    [Route("api/controller")]
    public class ProductsController : ControllerBase
    {
        private List<Product> _products = new List<Product>
        {
            new Product(1, "Chinelo", 10),
            new Product(2, "Tempero", 5),
            new Product(3, "Bicicleta", 50)
        };

        public ProductsController()
        {

        }

        //api/products HTTP GET
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_products);
        }
        //api/products/1
        [HttpGet ("{id}")]
        public IActionResult GetById(int id)
        {
            var product = _products.SingleOrDefault(p => p.Id == id);

            if(product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }
    }
}
