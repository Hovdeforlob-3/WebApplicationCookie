using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplicationCookie
{
    [Route("api/MilkShank")]
    [ApiController]
    public class Opg2SesenController : ControllerBase
    {
        // GET: api/<ValuesController>
        [HttpGet]
        public string Get(string milk)
        {
            CookieOptions cookie = new CookieOptions();
            DateTime timeNow = DateTime.Now;

            cookie.Expires = timeNow.AddMinutes(5);

            Response.Cookies.Append("favoriteMilkshake", milk,cookie);
            return "nygles milk shak er :" + milk; 
        }

        [HttpGet]
        [Route("[action]")]
        public string GetFromCookie()
        {
            string cookieRequst = Request.Cookies["favoriteMilkshake"];
            return "Kører : " + cookieRequst;
        }
    }
}
