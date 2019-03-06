using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description; 
using System.Net.Http;
using DeliveryManagement.BusinessLogic;
using Newtonsoft.Json.Linq;
using System.Text;


namespace DeliveryManagement.Controllers
{
    public class ApiDemoController : ApiController
    {
        public HttpResponseMessage GetDriver(int id)
        {

            var data = DriverLogic.SelectByPK(id);


            return new HttpResponseMessage()
            {
                Content = new StringContent(JArray.FromObject(data).ToString(), Encoding.UTF8, "application/json")
            }; 
        }

    }
}
