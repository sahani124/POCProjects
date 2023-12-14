using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerProjectCore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CustomerProjectCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerAPIController : ControllerBase
    {
        static List<Customer> Customers = new List<Customer>();
        // GET: api/CustomerAPI
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/CustomerAPI/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/CustomerAPI
        [HttpPost]
        public List<Customer> Post([FromBody] Customer obj)
        {
            Customers.Add(obj); // <-- replace ADO / EF
            return Customers;
        }

        // PUT: api/CustomerAPI/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
