using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplicationCookie
{
    [Route("api/DeleteCookie")]
    [ApiController]
    public class Opg1FDeleteCookieManult : ControllerBase
    {
        // GET: api/<Opg1FDeleteCookieManult>

        public CookieOptions Cookie = new CookieOptions();

        [HttpGet]
        public void Get()
        {
            Response.Cookies.Append("Password", "Admin123");
        }

        [HttpGet]
        [Route("[action]")]
        public void GetRemove()
        {
            Cookie.Expires = DateTime.Now;
            Response.Cookies.Append("Password", "", Cookie);
        }

    }
}
