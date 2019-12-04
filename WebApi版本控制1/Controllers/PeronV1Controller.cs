using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi版本控制1.Controllers
{
    [RoutePrefix("api/V1/Person")]
    public class PeronV1Controller : ApiController
    {
        [Route("{id}")]
        public string Get(int id)
        {
            return "我是V1" + id;
        }
    }
}
