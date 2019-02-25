using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DeliveryManagement.Models;
using System.Collections;

namespace DeliveryManagement.Controllers
{
    public class DemoWebApiController : ApiController
    {
        [HttpGet]
        public string getName()
        {
            return "Jay";
        }

        public IEnumerable<order_master> Get()
        {
            using (DeliveryEntities1 entities = new DeliveryEntities1())
            {
                return entities.order_master.ToList();
            }
        }

    }
}
