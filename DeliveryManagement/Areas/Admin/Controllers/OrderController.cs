using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DeliveryManagement.Areas.Admin.Controllers
{
    public class OrderController : Controller
    {
        DeliveryEntities1 db = new DeliveryEntities1();
        //
        // GET: /Admin/Order/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddOrder()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddOrder(order_master ord)
        {
            using (DeliveryEntities1 db = new DeliveryEntities1())
                if (ModelState.IsValid)
                {
                    string exist = Convert.ToString((from Data in db.order_master
                                                     where Data.mobileno.Trim().ToLower() == ord.mobileno.Trim().ToLower()
                                                     select Data.id).FirstOrDefault());
                    if (Convert.ToInt32(exist) == 0)
                    {
                        order_master Data_Insert = new order_master();
                        //Random r = new Random();
                        // int rid = r.Next(0, 999999);
                        // Data_Insert.driverid = drdt.driverid; 
                        Data_Insert.mobileno = ord.mobileno;
                        Data_Insert.pickupperson = ord.pickupperson;
                        //  Data_Insert.mobileno = ord.mobileno;
                        Data_Insert.pickupcontact = ord.pickupcontact;
                        Data_Insert.pickupitem = ord.pickupitem;
                        Data_Insert.deliverycontact = ord.deliverycontact;
                        Data_Insert.pickupaddress = ord.pickupaddress;
                        Data_Insert.deliveryaddress = ord.deliveryaddress;
                        Data_Insert.pickupmessage1 = ord.pickupmessage1;
                        Data_Insert.billingtype = ord.billingtype;
                        Data_Insert.billto = ord.billto;
                        Data_Insert.deliverycharge = ord.deliverycharge;
                        Data_Insert.pob = ord.pob;
                        Data_Insert.tocollect = ord.tocollect;
                        Data_Insert.orderdate = ord.orderdate;
                        Data_Insert.deliverydate = ord.deliverydate;
                        Data_Insert.pickuparea = ord.pickuparea;
                        Data_Insert.deliveryarea = ord.deliveryarea;
                        // Data_Insert.postalcode = drdt.postalcode;
                        Data_Insert.isactive = true;


                        db.order_master.Add(ord);
                        db.SaveChanges();


                        return RedirectToAction("Dashboard", "Login");

                    }
                    else
                    {
                        return RedirectToAction("Dashboard", "Login");
                    }



                }

            return View();
        }
        public ActionResult ViewOrder()
        {
            DeliveryEntities1 driver = new DeliveryEntities1();
            var data = driver.order_master.ToList();
            return View(data);
        }

        public ActionResult Edit(int id = 0)
        {
            order_master order = db.order_master.Find(id);
            if (order == null)
            {
                return HttpNotFound();

            }
            order_master ord = new order_master();
            ord.mobileno = order.mobileno;
            ord.deliveryitem = order.deliveryitem;
            ord.deliverycharge = order.deliverycharge;
            ord.deliverydate = order.deliverydate;
            return View(ord);
        }

        [HttpPost]
        public ActionResult Edit(order_master order)
        {
            using (DeliveryEntities1 db = new DeliveryEntities1())
                if (ModelState.IsValid)
                {
                    //    string exist = Convert.ToString((from Data in db.order_master
                    //                                     where Data.mobileno.Trim().ToLower() == order.mobileno.Trim().ToLower()
                    //                                     select Data.id).FirstOrDefault());
                    //    if (Convert.ToInt32(exist) == 0)
                    //    {
                    //        order_master Data_Insert = new order_master();
                    //        //Random r = new Random();
                    //        // int rid = r.Next(0, 999999);
                    //        // Data_Insert.driverid = drdt.driverid; 
                    //        Data_Insert.mobileno = order.mobileno;
                    //        //  Data_Insert.pickupperson = ord.pickupperson;
                    //        //  Data_Insert.mobileno = ord.mobileno;
                    //        // Data_Insert.pickupcontact = ord.pickupcontact;
                    //        Data_Insert.pickupitem = order.pickupitem;
                    //        //  Data_Insert.deliverycontact = ord.deliverycontact;
                    //        //   Data_Insert.pickupaddress = ord.pickupaddress;
                    //        //   Data_Insert.deliveryaddress = ord.deliveryaddress;
                    //        //   Data_Insert.pickupmessage1 = ord.pickupmessage1;
                    //        //   Data_Insert.billingtype = ord.billingtype;
                    //        //   Data_Insert.billto = ord.billto;
                    //        Data_Insert.deliverycharge = order.deliverycharge;
                    //        //   Data_Insert.pob = ord.pob;
                    //        //   Data_Insert.tocollect = ord.tocollect;
                    //        //    Data_Insert.orderdate = ord.orderdate;
                    //        Data_Insert.deliverydate = order.deliverydate;
                    //        //  Data_Insert.pickuparea = ord.pickuparea;
                    //        //  Data_Insert.deliveryarea = ord.deliveryarea;
                    //        // Data_Insert.postalcode = drdt.postalcode;
                    //        // Data_Insert.isactive = true;


                    //        db.SaveChanges();


                    //        return RedirectToAction("ViewOrder", "Order");

                    db.Entry(order).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("ViewOrder");


                }
                else
                {
                    return RedirectToAction("Dashboard", "Login");
                }
        
           }

    
        public ActionResult Delete(int id = 0)
        {
            order_master order = db.order_master.Find(id);
            if (order == null)
            {
                return HttpNotFound();

            }
            order_master ord = new order_master();
            ord.mobileno = order.mobileno;
            ord.deliveryitem = order.deliveryitem;
            ord.deliverycharge = order.deliverycharge;
            ord.deliverydate = order.deliverydate;
            return View(ord);

        }

        [HttpPost]
        public ActionResult Delete(order_master order)
        {
            using (DeliveryEntities1 db = new DeliveryEntities1())
                if (ModelState.IsValid)
                {
                    string exist = Convert.ToString((from Data in db.order_master
                                                     where Data.mobileno.Trim().ToLower() == order.mobileno.Trim().ToLower()
                                                     select Data.id).FirstOrDefault());
                    if (Convert.ToInt32(exist) == 0)
                    {
                        //        order_master Data_Insert = new order_master();
                        //        //Random r = new Random();
                        //        // int rid = r.Next(0, 999999);
                        //        // Data_Insert.driverid = drdt.driverid; 
                        //        Data_Insert.mobileno = order.mobileno;
                        //        //  Data_Insert.pickupperson = ord.pickupperson;
                        //        //  Data_Insert.mobileno = ord.mobileno;
                        //        // Data_Insert.pickupcontact = ord.pickupcontact;
                        //        Data_Insert.pickupitem = order.pickupitem;
                        //        //  Data_Insert.deliverycontact = ord.deliverycontact;
                        //        //   Data_Insert.pickupaddress = ord.pickupaddress;
                        //        //   Data_Insert.deliveryaddress = ord.deliveryaddress;
                        //        //   Data_Insert.pickupmessage1 = ord.pickupmessage1;
                        //        //   Data_Insert.billingtype = ord.billingtype;
                        //        //   Data_Insert.billto = ord.billto;
                        //        Data_Insert.deliverycharge = order.deliverycharge;
                        //        //   Data_Insert.pob = ord.pob;
                        //        //   Data_Insert.tocollect = ord.tocollect;
                        //        //    Data_Insert.orderdate = ord.orderdate;
                        //        Data_Insert.deliverydate = order.deliverydate;
                        //        //  Data_Insert.pickuparea = ord.pickuparea;
                        //        //  Data_Insert.deliveryarea = ord.deliveryarea;
                        //        // Data_Insert.postalcode = drdt.postalcode;
                        //        // Data_Insert.isactive = true;


                        //        db.SaveChanges();


                        //        return RedirectToAction("ViewOrder", "Order");

                        order.isactive = false;
                        db.Entry(order).State = EntityState.Modified;
                        db.SaveChanges();
                        return RedirectToAction("ViewOrder");


                    }
                    else
                    {
                        return RedirectToAction("Dashboard", "Login");
                    }

                   
                }
            return View();

        }
    }
}
