using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplicationCookie
{
    [Route("api/SetCookie")]
    [ApiController]
    public class Opg1ECookie : ControllerBase
    {
        /// <summary>
        /// Ja jeg kan godt hente en cookie med en anden controller
        /// </summary>
        // GET: api/<Opg1ECookie>
        [HttpGet]
        public void Get()
        {
            Response.Cookies.Append("username", "Admin");
        }

    }
}
