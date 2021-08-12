using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplicationCookie
{
    [Route("api/remove")]
    [ApiController]
    public class DeleteContoller : ControllerBase
    {
        // GET: api/<DeleteContoller>
        [HttpGet]
        public IEnumerable<Produckt> Get(string productName, int price)
        {
          List<Produckt> Shopingcart =  HttpContext.Session.GetObjectFromJson<List<Produckt>>("ShoppingCart");
            Produckt produckt = new Produckt();
            produckt.Name = productName;


            if (Shopingcart.Any(s => produckt.Name.Contains(productName)))
            {
                var itemToRemove = Shopingcart.Single(r => r.Name == productName);
                Shopingcart.Remove(itemToRemove);

                HttpContext.Session.SetObjectAsJson("ShoppingCart", Shopingcart);
            }  

            return Shopingcart;
        }
    }
}
