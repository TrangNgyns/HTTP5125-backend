using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assign1_n01472554.Controllers
{
    public class ExampleController : ApiController
    {
        //wow commenting
        //GET : localhost:xx/api/Example -> "A different welcomee"
        //the 2nd response is overwriting the first one (below)
        public string Get()
        {
            string response = "Welcome to HTTP5125";
            response = "A different welcome";
            return response;
        }

        //cant add a second (same) public string Get due to 1 already above / introduced the convention for this framework
        //GET: localhost:xx/api/Example/{id} -> curly brackets = placeholder
        public string Get(int id)
        {
            string message = "You entered number ";
            message = message + id;
            return message;
        }

        //POST:
        ///<summary> This listens for a post request & provides string response</summary>
        ///<returns>
        ///"A response to a POST request"
        ///</returns>
        ///<example>
        ///fjgfdh
        ///</example>
    }
}
