using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PV207.Models;

namespace PV207.Controllers
{
    public class ProductsController : ApiController
    {
        Product[] products = new Product[] 
        { 
            new Product { Id = 1, Name = "Ibalgin", Category = "General", Price = 50 }, 
            new Product { Id = 2, Name = "Soap", Category = "Drogery", Price = 35 }, 
            new Product { Id = 3, Name = "Tooth brush", Category = "Drogery", Price = 40 },
            new Product { Id = 3, Name = "Framykoin", Category = "Healing spread", Price = 150 },
            new Product { Id = 3, Name = "Olynth", Category = "Nose drops", Price = 150 } 
        };


        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }

        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        public IHttpActionResult GetProduct(string productName)
        {
            var product = products.FirstOrDefault((p) => p.Name == productName);
            if (product == null)
            {
                return Ok(false);
            }
            return Ok(true);
        }
    }
}
