using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace MVCSendGripJenkinsProDev.Controllers
{
    public class SubmitController : ApiController
    {
        // GET api/submit
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/submit/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/submit
        public HttpResponseMessage Post([FromBody]string value)
        {
            return new HttpResponseMessage(HttpStatusCode.InternalServerError);
        }

        // PUT api/submit/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/submit/5
        //public void Delete(int id)
        //{
        //}
    }
}
