using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Data;
using DeliveryManagement.Models;
using System.Collections;
using System.Web.Http;
using Newtonsoft.Json.Linq;
using System.Text;
using DeliveryManagement.BusinessLogic;
using System.Runtime.InteropServices;

namespace DeliveryManagement.Controllers
{
   
    public class DemoWebApiController : ApiController
    {
        //[HttpGet]
        //public string getName()
        //{
        //    return "xyz";
        //}

        //public IEnumerable<order_master> Get()
        //{
        //    using (DeliveryEntities1 entities = new DeliveryEntities1())
        //    {
        //        return entities.order_master.ToList();
        //    }
        //}

      //  [HttpGet]
        //public IHttpActionResult getOrders()
        //{
        //    using (DeliveryEntities1 entities = new DeliveryEntities1())
        //    {
        //        return entities.order_master.ToList();
        //    }
        //}

        [HttpGet]
        public HttpResponseMessage Get()
        {

            var data = OrderLogic.SelectAll();

            //return OK(data);
            return new HttpResponseMessage()
            {
                Content = new StringContent(JArray.FromObject(data).ToString(), Encoding.UTF8, "application/json")
            };
        }

       
        [HttpGet]
        public HttpResponseMessage findDrivers()
        {

            var data = DriverLogic.SelectAll();

            //return OK(data);
            return new HttpResponseMessage()
            {
                Content = new StringContent(JArray.FromObject(data).ToString(), Encoding.UTF8, "application/json")
            };
        }

        public HttpResponseMessage findOrderById(int id)
        {

            var data = OrderLogic.SelectByPK(id);

            return new HttpResponseMessage()
            {
                Content = new StringContent(JArray.FromObject(data).ToString(), Encoding.UTF8, "application/json")
            };
        }

       //// [HttpGet]
       //// [AcceptVerbs("GET", "POST")]
       // public HttpResponseMessage findDriverById(int id)
       // {
       //     var data = DriverLogic.SelectByPK(id);
            

       //     return new HttpResponseMessage()
       //     {
       //         Content = new StringContent(JArray.FromObject(data).ToString(), Encoding.UTF8, "application/json")
       //     }; 

       // }


    }
}
