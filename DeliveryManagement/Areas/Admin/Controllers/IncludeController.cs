using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DeliveryManagement.Areas.Admin.Controllers
{
    [DeliveryManagement.FilterConfig.NoDirectAccess]
 
    public class IncludeController : Controller
    {
        //
        // GET: /Admin/Include/
        
        public ActionResult Header ()
        {
            return View();
        }
        public ActionResult SideNav()
        {
            return View();
        }
        public ActionResult Footer()
        {
            return View();
        }
        public ActionResult Style()
        {
            return View();
        }

        public ActionResult Data()
        {
            DeliveryEntities1 driver = new DeliveryEntities1();
            var data = driver.order_master.ToList();
            return View(data);
         
        }

    }
}

