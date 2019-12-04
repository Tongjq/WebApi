using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi多版本管理_IHttpControllerSelector.Controllers.V2
{
    public class PersonV2Controller : ApiController
    {
        public string Get(int id)
        {
            return "我是V2版本" + id;
        }
    }
}
