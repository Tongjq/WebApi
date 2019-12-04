using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiFilter.Controllers
{
    public class LoginController : ApiController
    {
        public string ToLogin(string userName)
        {
            return userName + "登录成功";
        }

        public string GetError(string str)
        {
            throw new Exception("异常了"+str);
        }
    }
}
