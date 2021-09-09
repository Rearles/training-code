using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloRest.Models;
using Microsoft.AspNetCore.Mvc;


namespace HelloRest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        // GET: api/Email
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/Email/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/Email
        [HttpPost]
        public void Post([FromBody] Email email)
        {

        }

        // PUT api/Email/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Email email)
        {
        }
        
        // DELETE api/Email/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
