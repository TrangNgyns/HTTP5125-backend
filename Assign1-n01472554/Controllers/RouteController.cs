using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assign1_n01472554.Controllers
{
    public class RouteController : ApiController
    {
        // GET: api/Route/Method1
        //[annotationnn - helps clarify the convention Get/Post so u can deviate from it & replace thw words w smth else]
        [HttpGet]
        [Route("api/Route/Method1")]
        public string Method1()
        {
            return "method 1";
        }
        // GET: api/Route/Method2/{id}
        [HttpGet]
        [Route("api/Route/Method2")]
        public string Method2(int id)
        {
            string message = "Method 3 has an input of ";
            message = message + id;
            return message;
        }
        // GET: api/Route/Method3/{input1}/{input2}
        [HttpGet]
        [Route("api/Route/Method3/{input1}/{input2}")]
})]
        public string Method3(int input1, int input 2)
        {
            string output = "input 1 is " + input1;
            output = output + " and input 2 is " + input2;
            return output;
        }
        //POST: api/Route/Method4
        [HttpGet]
        [Route("api/Route/Method4")]
        public string Method4()
        {
            return "our POST request";
        }
    
    }
}
