using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Session;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplicationCookie
{
    [Route("api/Opg2")]
    [ApiController]
    public class Opg2Sessions : ControllerBase
    {
        // GET: api/<Opg2Sessions>
        [HttpGet]
        public List<string> Get()
        {
            User user = new User();
            user.name = "kan";
            user.totalPris = 191;

            List<string> pris = new List<string> { "mar", "2" };

            //HttpContext.Session.SetObjectAsJson("Test", pris);
            //return pris;
            HttpContext.Session.SetString("key", JsonConvert.SerializeObject("1234"));
            return pris;
        }
    }
}
