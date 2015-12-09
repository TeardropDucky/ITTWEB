using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HandIn2_FoodProcessor.Models;

namespace HandIn2_FoodProcessor.Controllers
{
    public class ProductsController : ApiController
    {
        Product[] products = new Product[]
        {
            new Product { Id = 1, Name = "Oksekød", Gram=20},
            new Product { Id = 2, Name = "Svinekød", Gram=20},
            new Product { Id = 3, Name = "Kylling", Gram=20},
            new Product { Id = 4, Name = "Æg", Gram=12.6},
            new Product { Id = 5, Name = "Minimælk", Gram=3.5},
            new Product { Id = 6, Name = "Havegryn", Gram=13.3},
            new Product { Id = 7, Name = "Rugbrød", Gram=6.2},
            new Product { Id = 8, Name = "Grønne bønner", Gram=2},
            new Product { Id = 9, Name = "Kartoffel", Gram=1.9}
        };

        //public IEnumerable<Product> GetAllProducts()
        //{
        //    return products;
        //}

        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}
