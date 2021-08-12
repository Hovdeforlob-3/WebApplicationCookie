using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplicationCookie
{
    [Route("api/shop")]
    [ApiController]
    public class ShopingCartController : ControllerBase
    {

        // GET: api/<ShopingCartController>
        [HttpGet]
        public IEnumerable<Produckt> Get(string productName, int price)
        {
            List<Produckt> ShoppingCart = HttpContext.Session.GetObjectFromJson<List<Produckt>>("ShoppingCart");

            if (HttpContext.Session.GetObjectFromJson<List<Produckt>>("ShoppingCart") == null)
            {
                ShoppingCart = new List<Produckt>();
                ShoppingCart.Add(new Produckt { Name = productName, Price = price });
                HttpContext.Session.SetObjectAsJson("ShoppingCart", ShoppingCart);
            }
            else
            {
                ShoppingCart.Add(new Produckt { Name = productName, Price = price });
                HttpContext.Session.SetObjectAsJson("ShoppingCart", ShoppingCart);
            }
            return ShoppingCart;
        }

        [HttpGet]
        [Route("[action]")]
        public IEnumerable<Produckt> GetCart()
        {
            List<Produckt> produckt = HttpContext.Session.GetObjectFromJson<List<Produckt>>("ShoppingCart");
            return produckt;
        }
    }
}
