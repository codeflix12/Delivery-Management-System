using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DeliveryManagement.Models
{
    public class order_master
    {
        public int id;
        public System.Guid driverid;
        public string orderstatus;
        public string mobileno;
        public int orderno;
        public string pickupperson;
        public string pickupcontact;
        public string pickupitem;
        public string deliveryperson;
        public string deliverycontact;
        public string deliveryitem;
        public string pickupaddress;
        public string deliveryaddress;
        public string pickupmessage1;
        public string pickupmessage2;
        public string pickupmessage3;
        public string pickupmessage4;
        public string pickupmessage5;
        public string billingtype;
        public string billto;
        public string deliverycharge;
        public string pob;
        public string tocollect;
        public DateTime orderdate;
        public DateTime deliverdate;
        public string pickuparea;
        public string deliveryarea;
        public int startpickupkh;
        public DateTime startpickupdate;
        public int pickuprichkh;
        public DateTime pickuprichdate;
        public DateTime pickupitemdate;
        public int startdeliverykh;
        public DateTime startdeliverydate;
        public int deliveryrichkh;
        public DateTime deliverydate;
        public string collectperson;
        public string collectphone;
        public string billno;
        public string yourorderno;
        public bool isread;
        public bool isremove;
        public bool isactive;
    }
}