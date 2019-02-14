using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DeliveryManagement.Areas.Admin.Controllers
{
    
    public class LoginController : Controller
    {
        //
        // GET: /Admin/Login/

        public ActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(admin objUser)
        {
            if (ModelState.IsValid)
            {
                using (DeliveryEntities1 db = new DeliveryEntities1())
                {
                    
                    var obj = db.admins.Where(a => a.username.Equals(objUser.username) && a.password.Equals(objUser.password)).FirstOrDefault();
                    if (obj != null)
                    {
                        Session["UserID"] = obj.userid.ToString();
                        Session["UserName"] = obj.username.ToString();


                        return RedirectToAction("DashBoard");
                       
                        
                    }
                        
                    else
                    {

                        ViewBag.Message = "UserName or password is wrong";
                        return View();
                    }
                    }
            }
            return View(objUser);
        }
        public ActionResult DashBoard()
        {
            DeliveryEntities1 driver = new DeliveryEntities1();
            var data = driver.order_master.ToList();
            return View(data);
            //return View();
            
        }

        public ActionResult LogOut()
        {
            Session["UserID"] = null;
            Session["UserName"] = null;

            RedirectToAction("Index");
            return View();
        }

    }
}
