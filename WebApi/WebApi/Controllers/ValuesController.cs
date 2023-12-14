using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5

        public string Get(int id,string b)
        {
            return b;
        }

        //public HttpResponseMessage Get([FromUri] GeoPoint value)
        //{
        //    GeoPoint s = new GeoPoint();

        //    if (2 == 2)
        //    public
        //        return Request.CreateResponse(HttpStatusCode.NotFound, value.id);
        //    }

          
        //}  
        //[HttpPost]  // for callthis method : http://localhost:2639/api/values/PostNewStudent?s=sss
        public void PostNewStudent([FromUri ]string s)
        {
        }

        // POST api/values
         void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
