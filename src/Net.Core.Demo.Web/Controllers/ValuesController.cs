﻿using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Net.Core.Demo.Web.Storage;

namespace Net.Core.Demo.Web.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly DemoAppContext _context;

        public ValuesController(DemoAppContext context)
        {
            _context = context;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            var user = _context.Users.FirstOrDefault();



            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
