using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DeliveryManagement.Areas.Admin.Controllers
{
    public class DriverController : Controller
    {
        //
        // GET: /Admin/Driver/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ViewDriver()
        {
            DeliveryEntities1 driver = new DeliveryEntities1();
            var data = driver.driverdetails.ToList();
            return View(data);
        }


        public ActionResult AddDriver()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddDriver(driverdetail drdt)
        {
            using (DeliveryEntities1 db = new DeliveryEntities1())

                if (ModelState.IsValid)
                {

                    //db.driverdetails.Add(drdt);
                    //db.SaveChanges();
                    

                     string exist = Convert.ToString((from Data in db.driverdetails
                                                     where Data.mobileno.Trim().ToLower() == drdt.mobileno.Trim().ToLower()
                                                     select Data.id).FirstOrDefault());
                    if (Convert.ToInt32(exist) == 0)
                    {
                        driverdetail Data_Insert = new driverdetail();
                   
                    //Random r = new Random();
                    //     int rid = r.Next(0, 999999);
                    //    // Data_Insert.driverid = drdt.driverid; 
                        var guid = Guid.NewGuid();
                        //Data_Insert.drivername = drdt.drivername;
                        Data_Insert.age = drdt.age;
                          //Data_Insert.mobileno = ord.mobileno;
                        Data_Insert.driverid = guid;
                        Data_Insert.drivername = drdt.drivername;
                        Data_Insert.address = drdt.address;
                        Data_Insert.familyno = drdt.familyno;
                        Data_Insert.mobileno = drdt.mobileno;
                        Data_Insert.vehicleno = drdt.vehicleno;
                        Data_Insert.relation = drdt.relation;
                        Data_Insert.bankname = drdt.bankname;
                        Data_Insert.acno = drdt.acno;
                        Data_Insert.branchname = drdt.branchname;
                        Data_Insert.bgroup = drdt.bgroup;
                        Data_Insert.familyno = drdt.familyno;
                        Data_Insert.licanceno = drdt.licanceno;
                        Data_Insert.ifsccode = drdt.ifsccode;
                        Data_Insert.residenceno = drdt.residenceno;

                         //Data_Insert.postalcode = drdt.postalcode;
                        Data_Insert.isactive = true;


                        db.driverdetails.Add(drdt);
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
        
    }
}




