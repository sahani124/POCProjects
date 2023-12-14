using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace WebApiTest.Controllers
{

    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ValuesController : ApiController
    {
       
        [HttpPost]
        // GET api/values
        [Route("api/Login/LoginDtls")]
        public IEnumerable<string> Get()
        {
            List<string> productName = new List<string>();
            productName.Add("Laptop");
            productName.Add("TV");
            productName.Add("Washing Machine");
            productName.Add("Mobile");
            productName.Add("Tablet");
            return productName;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
