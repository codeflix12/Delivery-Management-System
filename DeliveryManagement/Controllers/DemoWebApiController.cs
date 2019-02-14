using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DeliveryManagement.Controllers
{
    public class DemoWebApiController : ApiController
    {
        [HttpGet]
        public string getName()
        {
            return "Jay";
        }
    }
}
