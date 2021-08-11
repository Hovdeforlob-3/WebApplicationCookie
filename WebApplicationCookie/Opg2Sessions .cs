﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Session;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplicationCookie
{
    [Route("api/[controller]")]
    [ApiController]
    public class Opg2Sessions : ControllerBase
    {
        // GET: api/<Opg2Sessions>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<Opg2Sessions>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<Opg2Sessions>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<Opg2Sessions>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<Opg2Sessions>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
