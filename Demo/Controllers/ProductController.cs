using Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Demo.Controllers
{
    public class ProductController : ApiController
    {
        List<Product> listProduct = new List<Product>(){
            new Product { ID = 1, Name = "Nokia Lumia", Category="Nokia", Price= 200000},
            new Product { ID = 2, Name = "Nokia 1280", Category="Nokia", Price= 1000},
            new Product { ID = 1, Name = "Samsung S6", Category="Samsung", Price= 12000},
            new Product { ID = 1, Name = "Samsung S3", Category="Samsung", Price= 25000},
            new Product { ID = 1, Name = "Sony Xperia Z1", Category="Sony", Price= 23210},
            new Product { ID = 1, Name = "Nokia Lumia 930", Category="Nokia", Price= 220000},
        };
        public IEnumerable<Product> getAll()
        {
            return listProduct;
        }
        public IHttpActionResult getByID(int id)
        {
            var product = listProduct.FirstOrDefault(x => x.ID.Equals(id));
            if (product != null)
            {
                return Ok(product); // HTTP 200
            }
            else
            {
                return NotFound();
            }
        }

    }
}
