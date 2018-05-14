using AuthorizeSample.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace AuthorizeSample.Web.Api
{
    public class SampleApiController : ApiController
    {
        [CustomAuthorize(Tasks = ("Granular Task1, Granular Task2"))]
        public IHttpActionResult GetSample()
        {
            return Ok();
        }
    }
}