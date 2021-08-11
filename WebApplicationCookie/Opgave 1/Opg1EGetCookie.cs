using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplicationCookie
{
    [Route("api/GetCookie")]
    [ApiController]
    public class Opg1EGetCookie : ControllerBase
    {
        /// <summary>
        /// Ja jeg kan godt hente en cookie med en anden controller
        /// </summary>
        /// <returns></returns>
        // GET: api/<Opg1EGetCookie>
        [HttpGet]
        public string Get()
        {
           string requstedCookie = Request.Cookies["username"];
            return "this was the requsted cookie : " + requstedCookie;
        }

    }
}
