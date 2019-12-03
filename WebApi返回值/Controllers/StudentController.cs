using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi返回值.Controllers
{
    public class StudentController : ApiController
    {
        public void Get()
        {
        }
        public IHttpActionResult Get(int id)
        {
            if (id == 1)
            {
                return Ok();
            }
            if (id == 2)
            {
                return Json(new { State = "OK", Name = "test" });
            }
            if (id == 3)
            {
                return Content(HttpStatusCode.OK, "哈哈哈哈");
            }
            if (id == 4)
            {
                return NotFound();
            }

            return StatusCode(HttpStatusCode.InternalServerError);

        }

        public HttpResponseMessage Test()
        {
            FileStream file = File.OpenRead(@"c:/1/txt");
            HttpResponseMessage msg = new HttpResponseMessage();
            msg.StatusCode = HttpStatusCode.OK;
            //msg.Content = new StringContent("China");
            msg.Content = new StreamContent(file);
            msg.Headers.Add("HAHA","Hello");
            msg.Headers.Age = TimeSpan.FromDays(3);
            return msg;
        }
    }
}
