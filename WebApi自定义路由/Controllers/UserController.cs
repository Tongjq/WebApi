using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi自定义路由.Controllers
{
    [RoutePrefix("MyWeb")]
    public class UserController : ApiController
    {
        //[Route("MyWeb/API/Users")]
        [Route("API/Users")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value", "value2" };
        }
    }
}
