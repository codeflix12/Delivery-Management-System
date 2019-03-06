using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using DeliveryManagement.Models;
using DeliveryManagement.BusinessLogic;
using System.Web.Http.Routing;

namespace DeliveryManagement.Controllers
{
    public class DriverController : Controller
    {
        //
        // GET: /Driver/

        public ActionResult Index()
        {
            return View();
        }

        
        public ActionResult fetch()
        {
            driverdetail d1 = new driverdetail();
            d1.id = Convert.ToInt32(Request.Params["id"]);
            //d1.driverid = (Guid)["driverid"];
            d1.drivername = Request.Params["drivername"];
            d1.age = Request.Params["age"];
            d1.mobileno = Request.Params["mobileno"];
            d1.address = Request.Params["address"];
            d1.licanceno = Request.Params["licanceno"];
            d1.vehicleno = Request.Params["vehicleno"];
            d1.residenceno = Request.Params["residenceno"];
            d1.familyno = Request.Params["familyno"];
            d1.relation = Request.Params["relation"];
            d1.bgroup = Request.Params["bgroup"];
            d1.bankname = Request.Params["bankname"];
            d1.branchname = Request.Params["branchname"];
            d1.acno = Request.Params["acno"];
            d1.ifsccode = Request.Params["ifsccode"];
            d1.isactive = (Request.Params["isactive"] == "1");

            DataTable dt = DriverLogic.SelectAll();

            return View(dt);
        }

        public ActionResult AddDriver()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddDriverSubmit()
        {
            driverdetails dd = new Models.driverdetails();
            var guid = System.Guid.NewGuid();
            dd.driverid = guid;
            dd.drivername = Convert.ToString(Request.Params["drivername"]);
            dd.age = Convert.ToString(Request.Params["age"]);
            dd.mobileno = Convert.ToString(Request.Params["mobileno"]);
            dd.address = Convert.ToString(Request.Params["address"]);
            dd.licanceno = Convert.ToString(Request.Params["licanceno"]);
            dd.vehicleno = Convert.ToString(Request.Params["vehicleno"]);
            dd.residenceno = Convert.ToString(Request.Params["residenceno"]);
            dd.familyno = Convert.ToString(Request.Params["familyno"]);
            dd.relation = Convert.ToString(Request.Params["relation"]);
            dd.bgroup = Convert.ToString(Request.Params["bgroup"]);
            dd.bankname = Convert.ToString(Request.Params["bankname"]);
            dd.branchname = Convert.ToString(Request.Params["branchname"]);
            dd.acno = Convert.ToString(Request.Params["acno"]);
            dd.ifsccode = Convert.ToString(Request.Params["ifsccode"]);
            dd.isactive = Convert.ToBoolean(Request.Params["isactive"]);


            DriverLogic.Insert(dd);
            return RedirectToAction("fetch");

        }

        public ActionResult DriverEdit()
        {
            driverdetails dtls = DriverLogic.SelectByPK(Convert.ToInt32(Request.Params["id"]));

            return View(dtls);
        }

        [HttpPost]
        public ActionResult DriverEditSubmit()
        {
            int id = Convert.ToInt32(Request.Params["id"]);
            driverdetails dd = DriverLogic.SelectByPK(id);
            //dd.driverid = (Guid) Request.Params["driverid"];
            dd.id = Convert.ToInt32(Request.Params["id"]);
            dd.drivername = Convert.ToString(Request.Params["drivername"]);
            dd.age = Convert.ToString(Request.Params["age"]);
            dd.mobileno = Convert.ToString(Request.Params["mobileno"]);
            dd.address = Convert.ToString(Request.Params["address"]);
            dd.licanceno = Convert.ToString(Request.Params["licanceno"]);
            dd.vehicleno = Convert.ToString(Request.Params["vehicleno"]);
            dd.residenceno = Convert.ToString(Request.Params["residenceno"]);
            dd.familyno = Convert.ToString(Request.Params["familyno"]);
            dd.relation = Convert.ToString(Request.Params["relation"]);
            dd.bgroup = Convert.ToString(Request.Params["bgroup"]);
            dd.bankname = Convert.ToString(Request.Params["bankname"]);
            dd.branchname = Convert.ToString(Request.Params["branchname"]);
            dd.acno = Convert.ToString(Request.Params["acno"]);
            dd.ifsccode = Convert.ToString(Request.Params["ifsccode"]);
            dd.isactive = (Request.Params["isactive"] == "1");

            DriverLogic.Update(dd);

            return RedirectToAction("fetch");

        }

        public ActionResult DriverDelete()
        {
            driverdetails dtls = DriverLogic.SelectByPK(Convert.ToInt32(Request.Params["id"]));

            return View(dtls);
            
        }
       

        [HttpPost]
        public ActionResult DriverDeleteSubmit()
        {
            int id = Convert.ToInt32(Request.Params["id"]);
            driverdetails dd = DriverLogic.SelectByPK(id);
            //dd.driverid = (Guid) Request.Params["driverid"];
            dd.id = Convert.ToInt32(Request.Params["id"]);
            dd.drivername = Convert.ToString(Request.Params["drivername"]);
            dd.age = Convert.ToString(Request.Params["age"]);
            dd.mobileno = Convert.ToString(Request.Params["mobileno"]);
            dd.address = Convert.ToString(Request.Params["address"]);
            dd.licanceno = Convert.ToString(Request.Params["licanceno"]);
            dd.vehicleno = Convert.ToString(Request.Params["vehicleno"]);
            dd.residenceno = Convert.ToString(Request.Params["residenceno"]);
            dd.familyno = Convert.ToString(Request.Params["familyno"]);
            dd.relation = Convert.ToString(Request.Params["relation"]);
            dd.bgroup = Convert.ToString(Request.Params["bgroup"]);
            dd.bankname = Convert.ToString(Request.Params["bankname"]);
            dd.branchname = Convert.ToString(Request.Params["branchname"]);
            dd.acno = Convert.ToString(Request.Params["acno"]);
            dd.ifsccode = Convert.ToString(Request.Params["ifsccode"]);
            dd.isactive = false;
                

            DriverLogic.Update(dd);

            return RedirectToAction("fetch");

        }

        public ActionResult ViewDriverByID()
        {
            driverdetail d1 = new driverdetail();
            d1.id = Convert.ToInt32(Request.Params["id"]);
            //d1.driverid = (Guid)["driverid"];
            d1.drivername = Request.Params["drivername"];
            d1.age = Request.Params["age"];
            d1.mobileno = Request.Params["mobileno"];
            d1.address = Request.Params["address"];
            d1.licanceno = Request.Params["licanceno"];
            d1.vehicleno = Request.Params["vehicleno"];
            d1.residenceno = Request.Params["residenceno"];
            d1.familyno = Request.Params["familyno"];
            d1.relation = Request.Params["relation"];
            d1.bgroup = Request.Params["bgroup"];
            d1.bankname = Request.Params["bankname"];
            d1.branchname = Request.Params["branchname"];
            d1.acno = Request.Params["acno"];
            d1.ifsccode = Request.Params["ifsccode"];
            d1.isactive = (Request.Params["isactive"] == "1");

            DataTable dt = DriverLogic.SelectAll();

            return View(dt);
        }

        [HttpPost]
        public ActionResult AssignDriver(FormCollection collection)
        {
            int orderId = Convert.ToInt32(collection["orderId"]);
          //  int id = Convert.ToInt32(Request.Params["id"]);
            order_master dd = OrderLogic.SelectByPK(orderId);

            //dd.id = Convert.ToInt32(Request.Params["id"]);
            dd.id = Convert.ToInt32(collection["orderId"]);
            dd.driverid = (System.Guid.Parse(Request.Params["driverid"]));

            OrderLogic.UpdateID(dd);

            return RedirectToAction("ViewOrder", "Order");

        }


    }
}
