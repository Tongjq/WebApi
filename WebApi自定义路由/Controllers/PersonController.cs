using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace WebApi自定义路由.Controllers
{
    public class PersonController:ApiController
    {
        [Route("Login/{name}/{pwd}")]
        [HttpPost]
        public string Login(string name, string pwd)
        {
            return name + pwd;
        }
    }
}