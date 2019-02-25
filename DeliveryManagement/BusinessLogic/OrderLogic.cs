using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using DeliveryManagement.Models;
using DeliveryManagement.BusinessLogic;
using System.Data.SqlClient;
using DeliveryManagement.DataAccess;

namespace DeliveryManagement.BusinessLogic
{
    public class OrderLogic
    {

        public static DataTable SelectAll()
        {
            string query = "Select * from order_master";
            List<SqlParameter> parameters = new List<SqlParameter>();
            return DBHelper.SelectData(query, parameters);
        }
        public static int Insert(order_master dt)
        {
            string query = "INSERT INTO order_master(orderstatus,mobileno,orderno,pickupperson,pickupcontact,pickupitem,deliveryperson,deliverycontact,deliveryitem,pickupaddress,deliveryaddress,pickupmessage1,pickupmessage2,pickupmessage3,pickupmessage4,pickupmessage5,billingtype,billto,deliverycharge,pob,tocollect,orderdate,deliverdate,pickuparea,deliveryarea,startpickupkh,startpickupdate,pickuprichkh,pickuprichdate,pickupitemdate,startdeliverykh,startdeliverydate,deliveryrichkh,deliverydate,collectperson,collectphone,billno,yourorderno,isread,isremove,isactive) VALUES(@orderstatus,@mobileno, @orderno, @pickupperson,@pickupcontact, @pickupitem, @deliveryperson,@deliverycontact, @deliveryitem,@pickupaddress,@deliveryaddress,@pickupmessage1,@pickupmessage2,@pickupmessage3,@pickupmessage4,@pickupmessage5,@billingtype,@billto,@deliverycharge,@pob,@tocollect,@orderdate,@deliverdate,@pickuparea,@deliveryarea, @startpickupkh,@startpickupdate,@pickuprichkh,@pickuprichdate,@pickupitemdate,@startdeliverykh, @startdeliverydate,@deliveryrichkh,@deliverydate,@collectperson,@collectphone,@billno,@yourorderno,@isread,@isremove,@isactive)";
            List<SqlParameter> parameters = new List<SqlParameter>();
          //  parameters.Add(new SqlParameter("@id", dt.id));
           // parameters.Add(new SqlParameter("@driverid", dt.driverid));
            parameters.Add(new SqlParameter("@orderstatus", dt.orderstatus));
            parameters.Add(new SqlParameter("@mobileno", dt.mobileno));
            parameters.Add(new SqlParameter("@orderno", dt.orderno));
            parameters.Add(new SqlParameter("@pickupperson", dt.pickupperson));
            parameters.Add(new SqlParameter("@pickupcontact", dt.pickupcontact));
            parameters.Add(new SqlParameter("@pickupitem", dt.pickupitem));
            parameters.Add(new SqlParameter("@deliveryperson", dt.deliveryperson));
            parameters.Add(new SqlParameter("@deliverycontact", dt.deliverycontact));
            parameters.Add(new SqlParameter("@deliveryitem", dt.deliveryitem));
            parameters.Add(new SqlParameter("@pickupaddress", dt.pickupaddress));
            parameters.Add(new SqlParameter("@deliveryaddress", dt.deliveryaddress));
            parameters.Add(new SqlParameter("@pickupmessage1", dt.pickupmessage1));
            parameters.Add(new SqlParameter("@pickupmessage2", dt.pickupmessage2));
            parameters.Add(new SqlParameter("@pickupmessage3", dt.pickupmessage3));
            parameters.Add(new SqlParameter("@pickupmessage4", dt.pickupmessage4));
            parameters.Add(new SqlParameter("@pickupmessage5", dt.pickupmessage5));
            parameters.Add(new SqlParameter("@billingtype", dt.billingtype));
            parameters.Add(new SqlParameter("@billto", dt.billto));
            parameters.Add(new SqlParameter("@deliverycharge", dt.deliverycharge));
            parameters.Add(new SqlParameter("@pob", dt.pob));
            parameters.Add(new SqlParameter("@tocollect", dt.tocollect));
            parameters.Add(new SqlParameter("@orderdate", dt.orderdate));              
            parameters.Add(new SqlParameter("@deliverdate", dt.deliverdate));
            parameters.Add(new SqlParameter("@pickuparea", dt.pickuparea));
            parameters.Add(new SqlParameter("@deliveryarea", dt.deliveryarea));
            parameters.Add(new SqlParameter("@startpickupkh", dt.startpickupkh));
            parameters.Add(new SqlParameter("@startpickupdate", dt.startpickupdate));
            parameters.Add(new SqlParameter("@pickuprichkh", dt.pickuprichkh));
            parameters.Add(new SqlParameter("@pickuprichdate", dt.pickuprichdate));    
            parameters.Add(new SqlParameter("@pickupitemdate", dt.pickupitemdate));
            parameters.Add(new SqlParameter("@startdeliverykh", dt.startdeliverykh));
            parameters.Add(new SqlParameter("@startdeliverydate", dt.startdeliverydate));
            parameters.Add(new SqlParameter("@deliveryrichkh", dt.deliveryrichkh));
            parameters.Add(new SqlParameter("@deliverydate", dt.deliverydate));
            parameters.Add(new SqlParameter("@collectperson", dt.collectperson));
            parameters.Add(new SqlParameter("@collectphone", dt.collectphone));
            parameters.Add(new SqlParameter("@billno", dt.billno));
            parameters.Add(new SqlParameter("@yourorderno", dt.yourorderno));
            parameters.Add(new SqlParameter("@isread", dt.isread));
            parameters.Add(new SqlParameter("@isremove", dt.isremove));
            parameters.Add(new SqlParameter("@isactive", dt.isactive));

            return DBHelper.ModifyData(query, parameters);

        }


        public static int Update(order_master dt)
        {
            string query = "UPDATE order_master SET orderstatus = @orderstatus,mobileno = @mobileno,orderno = @orderno,pickupperson = @pickupperson,pickupcontact = @pickupcontact,pickupitem = @pickupitem,deliveryperson = @deliveryperson,deliverycontact = @deliverycontact,deliveryitem = @deliveryitem,pickupaddress = @pickupaddress,deliveryaddress = @deliveryaddress,pickupmessage1 = @pickupmessage1,pickupmessage2 = @pickupmessage2,pickupmessage3 = @pickupmessage3,pickupmessage4 = @pickupmessage4,pickupmessage5 = @pickupmessage5,billingtype = @billingtype,billto = @billto,deliverycharge = @deliverycharge,pob = @pob,tocollect = @tocollect,orderdate = @orderdate,deliverdate = @deliverdate,pickuparea = @pickuparea,deliveryarea = @deliveryarea,startpickupkh = @startpickupkh,startpickupdate = @startpickupdate,pickuprichkh = @pickuprichkh,pickuprichdate = @pickuprichdate,pickupitemdate = @pickupitemdate,startdeliverykh = @startdeliverykh,startdeliverydate = @startdeliverydate,deliveryrichkh = @deliveryrichkh,deliverydate = @deliverydate,collectperson = @collectperson,collectphone = @collectphone,billno = @billno,yourorderno = @yourorderno,isread = isread,isremove = @isremove,isactive = @isactive WHERE id = @id";
 
            List<SqlParameter> parameters = new List<SqlParameter>();
            //parameters.Add(new SqlParameter("@driverid", dt.driverid));
            parameters.Add(new SqlParameter("@id", dt.id));
            parameters.Add(new SqlParameter("@orderstatus", dt.orderstatus));
            parameters.Add(new SqlParameter("@mobileno", dt.mobileno));
            parameters.Add(new SqlParameter("@orderno", dt.orderno));
            parameters.Add(new SqlParameter("@pickupperson", dt.pickupperson));
            parameters.Add(new SqlParameter("@pickupcontact", dt.pickupcontact));
            parameters.Add(new SqlParameter("@pickupitem", dt.pickupitem));
            parameters.Add(new SqlParameter("@deliveryperson", dt.deliveryperson));
            parameters.Add(new SqlParameter("@deliverycontact", dt.deliverycontact));
            parameters.Add(new SqlParameter("@deliveryitem", dt.deliveryitem));
            parameters.Add(new SqlParameter("@pickupaddress", dt.pickupaddress));
            parameters.Add(new SqlParameter("@deliveryaddress", dt.deliveryaddress));
            parameters.Add(new SqlParameter("@pickupmessage1", dt.pickupmessage1));
            parameters.Add(new SqlParameter("@pickupmessage2", dt.pickupmessage2));
            parameters.Add(new SqlParameter("@pickupmessage3", dt.pickupmessage3));
            parameters.Add(new SqlParameter("@pickupmessage4", dt.pickupmessage4));
            parameters.Add(new SqlParameter("@pickupmessage5", dt.pickupmessage5));
            parameters.Add(new SqlParameter("@billingtype", dt.billingtype));
            parameters.Add(new SqlParameter("@billto", dt.billto));
            parameters.Add(new SqlParameter("@deliverycharge", dt.deliverycharge));
            parameters.Add(new SqlParameter("@pob", dt.pob));
            parameters.Add(new SqlParameter("@tocollect", dt.tocollect));
            parameters.Add(new SqlParameter("@orderdate", dt.orderdate));
            parameters.Add(new SqlParameter("@deliverdate", dt.deliverdate));
            parameters.Add(new SqlParameter("@pickuparea", dt.pickuparea));
            parameters.Add(new SqlParameter("@deliveryarea", dt.deliveryarea));
            parameters.Add(new SqlParameter("@startpickupkh", dt.startpickupkh));
            parameters.Add(new SqlParameter("@startpickupdate", dt.startpickupdate));
            parameters.Add(new SqlParameter("@pickuprichkh", dt.pickuprichkh));
            parameters.Add(new SqlParameter("@pickuprichdate", dt.pickuprichdate));
            parameters.Add(new SqlParameter("@pickupitemdate", dt.pickupitemdate));
            parameters.Add(new SqlParameter("@startdeliverykh", dt.startdeliverykh));
            parameters.Add(new SqlParameter("@startdeliverydate", dt.startdeliverydate));
            parameters.Add(new SqlParameter("@deliveryrichkh", dt.deliveryrichkh));
            parameters.Add(new SqlParameter("@deliverydate", dt.deliverydate));
            parameters.Add(new SqlParameter("@collectperson", dt.collectperson));
            parameters.Add(new SqlParameter("@collectphone", dt.collectphone));
            parameters.Add(new SqlParameter("@billno", dt.billno));
            parameters.Add(new SqlParameter("@yourorderno", dt.yourorderno));
            parameters.Add(new SqlParameter("@isread", dt.isread));
            parameters.Add(new SqlParameter("@isremove", dt.isremove));
            parameters.Add(new SqlParameter("@isactive", dt.isactive));


            return DBHelper.ModifyData(query, parameters);
        }



        public static int UpdateID(order_master dt)
        {
            string query = "UPDATE order_master SET driverid = @driverid WHERE id = @id";

            List<SqlParameter> parameters = new List<SqlParameter>();


            int id = Convert.ToInt32(dt.id);
            System.Guid driverId = dt.driverid;

            parameters.Add(new SqlParameter("@id", id));
            parameters.Add(new SqlParameter("@driverid", driverId));

            return DBHelper.ModifyData(query, parameters);

            //SqlConnection connection = new SqlConnection("Data Source=LAPTOP-CELLHC4D;Initial Catalog=Delivery;Persist Security Info=True;User ID=sa;Password=root;MultipleActiveResultSets=True;Application Name=EntityFramework");
            //SqlCommand commend = new SqlCommand()

        }



        public static order_master SelectByPK(int ID)
        {
            string query = "SELECT * FROM order_master WHERE id = @id";
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@id", ID));
            DataTable dt = DBHelper.SelectData(query, parameters);
            order_master d = new order_master();
            if (dt.Rows.Count == 0)
            {
                return d;
            }
            else
            {

                d.id = ID;
              //  d.driverid = (Guid)dt.Rows[0]["driverid"];
                d.orderstatus = dt.Rows[0]["orderstatus"].ToString();
                d.orderno = Convert.ToInt32(dt.Rows[0]["orderno"]);
                d.mobileno = dt.Rows[0]["mobileno"].ToString();
                d.pickupperson = dt.Rows[0]["pickupperson"].ToString();
                d.pickupcontact = dt.Rows[0]["pickupcontact"].ToString();
                d.pickupitem = dt.Rows[0]["pickupitem"].ToString();
                d.deliveryperson = dt.Rows[0]["deliveryperson"].ToString();
                d.deliverycontact = dt.Rows[0]["deliverycontact"].ToString();
                d.deliveryitem = dt.Rows[0]["deliveryitem"].ToString();
                d.pickupaddress = dt.Rows[0]["pickupaddress"].ToString();
                d.deliveryaddress = dt.Rows[0]["deliveryaddress"].ToString();
                d.pickupmessage1 = dt.Rows[0]["pickupmessage1"].ToString();
                d.pickupmessage2 = dt.Rows[0]["pickupmessage2"].ToString();
                d.pickupmessage3 = dt.Rows[0]["pickupmessage3"].ToString();
                d.pickupmessage4 = dt.Rows[0]["pickupmessage4"].ToString();
                d.pickupmessage5 = dt.Rows[0]["pickupmessage5"].ToString();
                d.billingtype = dt.Rows[0]["billingtype"].ToString();
                d.billto = dt.Rows[0]["billto"].ToString();
                d.deliverycharge = dt.Rows[0]["deliverycharge"].ToString();
                d.pob = dt.Rows[0]["pob"].ToString();
                d.tocollect = dt.Rows[0]["tocollect"].ToString();
                d.orderdate = Convert.ToDateTime(dt.Rows[0]["orderdate"]);
                d.deliverdate = Convert.ToDateTime(dt.Rows[0]["deliverdate"]);
                d.pickupmessage1 = dt.Rows[0]["pickupmessage1"].ToString();
                d.pickuparea = dt.Rows[0]["pickuparea"].ToString();
                d.deliveryarea = dt.Rows[0]["deliveryarea"].ToString();
                d.startpickupkh = Convert.ToInt32(dt.Rows[0]["startpickupkh"]);
                d.startpickupdate = Convert.ToDateTime(dt.Rows[0]["startpickupdate"]);
                d.pickuprichkh = Convert.ToInt32(dt.Rows[0]["pickuprichkh"]);
                d.pickuprichdate = Convert.ToDateTime(dt.Rows[0]["pickuprichdate"]);
                d.pickupitemdate = Convert.ToDateTime(dt.Rows[0]["pickupitemdate"]);
                d.startdeliverykh = Convert.ToInt32(dt.Rows[0]["startdeliverykh"]);
                d.startdeliverydate = Convert.ToDateTime(dt.Rows[0]["startdeliverydate"]);
                d.deliveryrichkh = Convert.ToInt32(dt.Rows[0]["deliveryrichkh"]);
                d.deliverydate = Convert.ToDateTime(dt.Rows[0]["deliverydate"]);
                d.collectperson = dt.Rows[0]["collectperson"].ToString();
                d.collectphone = dt.Rows[0]["collectphone"].ToString();
                d.billno = dt.Rows[0]["billno"].ToString();
                d.yourorderno = dt.Rows[0]["yourorderno"].ToString();
                d.isread = dt.Rows[0]["isread"].ToString();
                d.isremove = dt.Rows[0]["isremove"].ToString();
                d.isactive = (bool)dt.Rows[0]["isactive"];


                return d;
            }
        }

    }
}