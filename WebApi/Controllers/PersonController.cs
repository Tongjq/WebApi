using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class PersonController : ApiController
    {
     
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}
       
        //public string Get(string name)
        //{
        //    return name;
        //}
      
        //public string GetByPhoneNum(string phoneNum)
        //{
        //    return phoneNum;
        //}

            // 如果参数是两个或者两个以上或者对象参数，就得加上请求类型[HttpGet]
        [HttpGet]
        public string Login(string test, string password)
        {
            return test + password;
        }
        [HttpGet]
        public string Login([FromUri] Person person)
        {
            return person.Name + person.Password;
        }
        // Post请求

        //public string Post([FromBody]string value)
        //{
        //    return "收到Post, value=" + value;
        //}
        // http://localhost:53170/api/Person?value=11212121212121212
        public string Post1([FromUri]string value)
        {
            return "收到PostUri, value=" + value;
        }


        // 如果有两个[FromBody]的Post方法会找不找
        public string PostObject([FromBody]Person person)
        {
            return person.Name + person.Password;
        }

        // put
        public string Put(int id, [FromBody] string value)
        {
            return "收到Put, value=" + value+id;
        }

        //delete
        public string Delete(int id)
        {
            return "收到Delete, Id=" + id;
        }

    }

}
