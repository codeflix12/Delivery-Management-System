using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DeliveryManagement.Models
{
    public class location
    {
        public int id;
        public System.Guid driverid;
        public string name;
        public float latitude;
        public float longitude;
        public string description;
    }
}