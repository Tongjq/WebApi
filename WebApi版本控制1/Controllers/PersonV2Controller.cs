using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi版本控制1.Controllers
{
    [RoutePrefix("api/V2/Person")]
    public class PersonV2Controller : ApiController
    {
        [Route("{id}")]
        public string Get(int id)
        {
            return "我是V2" + id;
        }
    }
}
