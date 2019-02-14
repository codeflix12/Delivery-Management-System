using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using DeliveryManagement.Models;
using DeliveryManagement.BusinessLogic;


namespace DeliveryManagement.Controllers
{
    public class OrderController : Controller
    {
        //
        // GET: /Order/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ViewOrder()
        {
            order_master om = new order_master();
            om.id = Convert.ToInt32(Request.Params["id"]);
            //d1.driverid = (Guid)["driverid"];
            
            om.orderstatus = Request.Params["orderstatus"];
            
            om.mobileno = Request.Params["mobileno"];
            om.orderno = Convert.ToInt32(Request.Params["orderno"]);
            om.pickupperson = Request.Params["pickupperson"];
            om.pickupcontact = Request.Params["pickupcontact"];            
            om.pickupitem = Request.Params["pickupitem"];
            om.deliveryperson = Request.Params["deliveryperson"];
            om.deliverycontact = Request.Params["deliverycontact"];
            om.deliveryitem = Request.Params["deliveryitem"];
            om.pickupaddress = Request.Params["pickupaddress"];
            om.deliveryaddress = Request.Params["deliveryaddress"];
            om.pickupmessage1 = Request.Params["pickupmessage1"];
            om.pickupmessage2 = Request.Params["pickupmessage2"];
            om.pickupmessage3 = Request.Params["pickupmessage3"];
            om.pickupmessage4 = Request.Params["pickupmessage4"];
            om.pickupmessage5 = Request.Params["pickupmessage5"];
            om.billingtype = Request.Params["billingtype"];
            om.billto = Request.Params["billto"];
            om.deliverycharge = Request.Params["deliverycharge"];
            om.pob = Request.Params["pob"];
            om.tocollect = Request.Params["tocollect"];
            om.orderdate = Convert.ToDateTime(Request.Params["orderdate"]);
            om.deliverdate = Convert.ToDateTime(Request.Params["deliverdate"]);
            om.pickuparea = Request.Params["pickuparea"];
            om.deliveryarea = Request.Params["deliveryarea"];
            om.startpickupkh = Convert.ToInt32(Request.Params["startpickupkh"]);
            om.startpickupdate = Convert.ToDateTime(Request.Params["startpickupdate"]);
            om.pickuprichkh = Convert.ToInt32(Request.Params["pickuprichkh"]);
            om.pickuprichdate = Convert.ToDateTime(Request.Params["pickuprichdate"]);
            om.pickupitemdate = Convert.ToDateTime(Request.Params["pickupitemdate"]);
            om.startdeliverykh = Convert.ToInt32(Request.Params["startdeliverykh"]);
            om.startdeliverydate = Convert.ToDateTime(Request.Params["startdeliverydate"]);
            om.deliveryrichkh = Convert.ToInt32(Request.Params["deliveryrichkh"]);
            om.deliverydate = Convert.ToDateTime(Request.Params["deliverydate"]);
            om.collectperson = Request.Params["collectperson"];
            om.startdeliverykh = Convert.ToInt32(Request.Params["startdeliverykh"]);
            om.collectphone = Request.Params["collectphone"];
            om.billno = Request.Params["billno"];
            om.yourorderno = Request.Params["yourorderno"];
            om.isread = Request.Params["isread"];
            om.isremove = Request.Params["isremove"];
            om.isactive = (Request.Params["isactive"] == "1");

            DataTable dt = OrderLogic.SelectAll();

            return View(dt);
        }

        public ActionResult AddOrder()
        {
            return View();
        }

        public ActionResult AddOrderSubmit()
        {
            order_master om = new order_master();

            //d1.driverid = (Guid)["driverid"];
            //om.driverid = System.Guid.Parse((Request.Params["driverid"]));
                        
            om.orderstatus = Request.Params["orderstatus"];
            om.mobileno = Request.Params["mobileno"];
            om.orderno = Convert.ToInt32(Request.Params["orderno"]);
            om.pickupperson = Request.Params["pickupperson"];
            om.pickupcontact = Request.Params["pickupcontact"];            
            om.pickupitem = Request.Params["pickupitem"];
            om.deliveryperson = Request.Params["deliveryperson"];
            om.deliverycontact = Request.Params["deliverycontact"];
            om.deliveryitem = Request.Params["deliveryitem"];
            om.pickupaddress = Request.Params["pickupaddress"];
            om.deliveryaddress = Request.Params["deliveryaddress"];
            om.pickupmessage1 = Request.Params["pickupmessage1"];
            om.pickupmessage2 = Request.Params["pickupmessage2"];
            om.pickupmessage3 = Request.Params["pickupmessage3"];
            om.pickupmessage4 = Request.Params["pickupmessage4"];
            om.pickupmessage5 = Request.Params["pickupmessage5"];
            om.billingtype = Request.Params["billingtype"];
            om.billto = Request.Params["billto"];
            om.deliverycharge = Request.Params["deliverycharge"];
            om.pob = Request.Params["pob"];
            om.tocollect = Request.Params["tocollect"];
            om.orderdate = Convert.ToDateTime(Request.Params["orderdate"]);
            om.deliverdate = Convert.ToDateTime(Request.Params["deliverdate"]);
            om.pickuparea = Request.Params["pickuparea"];
            om.deliveryarea = Request.Params["deliveryarea"];
            om.startpickupkh = Convert.ToInt32(Request.Params["startpickupkh"]);
            om.startpickupdate = DateTime.Now;
            om.pickuprichkh = Convert.ToInt32(Request.Params["pickuprichkh"]);
            om.pickuprichdate = DateTime.Now;
            om.pickupitemdate = DateTime.Now;
            om.startdeliverykh = Convert.ToInt32(Request.Params["startdeliverykh"]);
            om.startdeliverydate = DateTime.Now;
            om.deliveryrichkh = Convert.ToInt32(Request.Params["deliveryrichkh"]);
            om.deliverydate = DateTime.Now;
            om.collectperson = Request.Params["collectperson"];
            om.startdeliverykh = Convert.ToInt32(Request.Params["startdeliverykh"]);
            om.collectphone = Request.Params["collectphone"];
            om.billno = Request.Params["billno"];
            om.yourorderno = Request.Params["yourorderno"];
            om.isread = Request.Params["isread"];
            om.isremove = Request.Params["isremove"];
            om.isactive = Convert.ToBoolean(Request.Params["isactive"]);


            OrderLogic.Insert(om);
            return RedirectToAction("ViewDriverByID", "Driver");

        }

        public ActionResult OrderEdit()
        {
            order_master dtls = OrderLogic.SelectByPK(Convert.ToInt32(Request.Params["id"]));

            return View(dtls);
        }

        [HttpPost]
        public ActionResult OrderEditSubmit()
        {
            int id = Convert.ToInt32(Request.Params["id"]);
            order_master om = new order_master();
                                    
            //d1.driverid = (Guid)["driverid"];
            om.id = Convert.ToInt16(Request.Params["id"]);
            om.driverid = System.Guid.Parse(Request.Params["driverid"]);
            om.orderstatus = Request.Params["orderstatus"];
            om.mobileno = Request.Params["mobileno"];
            om.orderno = Convert.ToInt32(Request.Params["orderno"]);
            om.pickupperson = Request.Params["pickupperson"];
            om.pickupcontact = Request.Params["pickupcontact"];
            om.pickupitem = Request.Params["pickupitem"];
            om.deliveryperson = Request.Params["deliveryperson"];
            om.deliverycontact = Request.Params["deliverycontact"];
            om.deliveryitem = Request.Params["deliveryitem"];
            om.pickupaddress = Request.Params["pickupaddress"];
            om.deliveryaddress = Request.Params["deliveryaddress"];
            om.pickupmessage1 = Request.Params["pickupmessage1"];
            om.pickupmessage2 = Request.Params["pickupmessage2"];
            om.pickupmessage3 = Request.Params["pickupmessage3"];
            om.pickupmessage4 = Request.Params["pickupmessage4"];
            om.pickupmessage5 = Request.Params["pickupmessage5"];
            om.billingtype = Request.Params["billingtype"];
            om.billto = Request.Params["billto"];
            om.deliverycharge = Request.Params["deliverycharge"];
            om.pob = Request.Params["pob"];
            om.tocollect = Request.Params["tocollect"];
            om.orderdate = Convert.ToDateTime(Request.Params["orderdate"]);
            om.deliverdate = Convert.ToDateTime(Request.Params["deliverdate"]);
            om.pickuparea = Request.Params["pickuparea"];
            om.deliveryarea = Request.Params["deliveryarea"];
            om.startpickupkh = Convert.ToInt32(Request.Params["startpickupkh"]);
            om.startpickupdate = DateTime.Now;
            om.pickuprichkh = Convert.ToInt32(Request.Params["pickuprichkh"]);
            om.pickuprichdate = DateTime.Now;
            om.pickupitemdate = DateTime.Now;
            om.startdeliverykh = Convert.ToInt32(Request.Params["startdeliverykh"]);
            om.startdeliverydate = DateTime.Now;
            om.deliveryrichkh = Convert.ToInt32(Request.Params["deliveryrichkh"]);
            om.deliverydate = DateTime.Now;
            om.collectperson = Request.Params["collectperson"];
            om.startdeliverykh = Convert.ToInt32(Request.Params["startdeliverykh"]);
            om.collectphone = Request.Params["collectphone"];
            om.billno = Request.Params["billno"];
            om.yourorderno = Request.Params["yourorderno"];
            om.isread = Request.Params["isread"];
            om.isremove = Request.Params["isremove"];
            om.isactive = (Request.Params["isactive"] == "1");


            OrderLogic.Update(om);
            return RedirectToAction("ViewOrder");

        }

        public ActionResult OrderDelete()
        {
            order_master dtls = OrderLogic.SelectByPK(Convert.ToInt32(Request.Params["id"]));

            return View(dtls);
        }

        [HttpPost]
        public ActionResult OrderDeleteSubmit()
        {
            int id = Convert.ToInt32(Request.Params["id"]);
            order_master om = new order_master();

            //d1.driverid = (Guid)["driverid"];
            om.id = Convert.ToInt16(Request.Params["id"]);
            om.driverid = System.Guid.Parse(Request.Params["driverid"]);
            om.orderstatus = Request.Params["orderstatus"];
            om.mobileno = Request.Params["mobileno"];
            om.orderno = Convert.ToInt32(Request.Params["orderno"]);
            om.pickupperson = Request.Params["pickupperson"];
            om.pickupcontact = Request.Params["pickupcontact"];
            om.pickupitem = Request.Params["pickupitem"];
            om.deliveryperson = Request.Params["deliveryperson"];
            om.deliverycontact = Request.Params["deliverycontact"];
            om.deliveryitem = Request.Params["deliveryitem"];
            om.pickupaddress = Request.Params["pickupaddress"];
            om.deliveryaddress = Request.Params["deliveryaddress"];
            om.pickupmessage1 = Request.Params["pickupmessage1"];
            om.pickupmessage2 = Request.Params["pickupmessage2"];
            om.pickupmessage3 = Request.Params["pickupmessage3"];
            om.pickupmessage4 = Request.Params["pickupmessage4"];
            om.pickupmessage5 = Request.Params["pickupmessage5"];
            om.billingtype = Request.Params["billingtype"];
            om.billto = Request.Params["billto"];
            om.deliverycharge = Request.Params["deliverycharge"];
            om.pob = Request.Params["pob"];
            om.tocollect = Request.Params["tocollect"];
            om.orderdate = Convert.ToDateTime(Request.Params["orderdate"]);
            om.deliverdate = Convert.ToDateTime(Request.Params["deliverdate"]);
            om.pickuparea = Request.Params["pickuparea"];
            om.deliveryarea = Request.Params["deliveryarea"];
            om.startpickupkh = Convert.ToInt32(Request.Params["startpickupkh"]);
            om.startpickupdate = DateTime.Now;
            om.pickuprichkh = Convert.ToInt32(Request.Params["pickuprichkh"]);
            om.pickuprichdate = DateTime.Now;
            om.pickupitemdate = DateTime.Now;
            om.startdeliverykh = Convert.ToInt32(Request.Params["startdeliverykh"]);
            om.startdeliverydate = DateTime.Now;
            om.deliveryrichkh = Convert.ToInt32(Request.Params["deliveryrichkh"]);
            om.deliverydate = DateTime.Now;
            om.collectperson = Request.Params["collectperson"];
            om.startdeliverykh = Convert.ToInt32(Request.Params["startdeliverykh"]);
            om.collectphone = Request.Params["collectphone"];
            om.billno = Request.Params["billno"];
            om.yourorderno = Request.Params["yourorderno"];
            om.isread = Request.Params["isread"];
            om.isremove = Request.Params["isremove"];
            om.isactive = Convert.ToBoolean(Request.Params["isactive"]);


            OrderLogic.Update(om);
            return RedirectToAction("ViewOrder");
        }
        
    }
}
