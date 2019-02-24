using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Reshimgathi.Controllers
{
    public class HomeAlertController : ApiController
    {
        // GET: api/HomeAlert
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/HomeAlert/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/HomeAlert
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/HomeAlert/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/HomeAlert/5
        public void Delete(int id)
        {
        }
    }
}
