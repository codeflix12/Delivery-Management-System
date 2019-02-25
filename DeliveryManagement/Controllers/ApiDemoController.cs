using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DeliveryManagement.Controllers
{
    public class ApiDemoController : ApiController
    {
        [HttpGet]
        public IEnumerable<order_master> Get()
        {            
            using (DeliveryEntities1 entities = new DeliveryEntities1())
            {
                return entities.order_master.ToList();
            }
        }

        public order_master Get(int id)
        {
            using (DeliveryEntities1 entities = new DeliveryEntities1())
            {
                return entities.order_master.FirstOrDefault(e => e.id == id);
            }
        }

    }
}
