using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DeliveryManagement.Models;
using DeliveryManagement.DataAccess;
using DeliveryManagement.BusinessLogic;

namespace DeliveryManagement.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /Login/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            Session["admin"] = null;
            return View();
        }

        [HttpPost]
        public ActionResult LoginSubmit()
        {
            admin s = AdminLogic.SelectByUnPw(Request.Params["username"], Request.Params["password"]);
            
            if (s.userid > 0)
            {
                Session["admin"] = s;
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Login");
            }
       }
                
        
    }
}
