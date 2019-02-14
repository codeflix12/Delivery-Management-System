using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DeliveryManagement.Controllers
{
    public class IncludeController : Controller
    {
        //
        // GET: /Include/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Header()
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

    }
}
