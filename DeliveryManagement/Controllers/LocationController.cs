using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Sql;
using System.Data.SqlClient;

namespace DeliveryManagement.Controllers
{
    public class LocationController : Controller
    {
        //
        // GET: /Location/

        public ActionResult Index()
        {
            string markers = "[";
            string conString = "Data Source=LAPTOP-CELLHC4D;Initial Catalog=Delivery;Persist Security Info=True;User ID=sa;Password=root;MultipleActiveResultSets=True;Application Name=EntityFramework";
            SqlCommand cmd = new SqlCommand("SELECT * FROM location");
            using (SqlConnection con = new SqlConnection(conString))
            {
                cmd.Connection = con;
                con.Open();
                using (SqlDataReader sdr = cmd.ExecuteReader())
                {
                    while (sdr.Read())
                    {
                        markers += "{";
                        markers += string.Format("'title': '{0}',", sdr["Name"]);
                        markers += string.Format("'lat': '{0}',", sdr["Latitude"]);
                        markers += string.Format("'lng': '{0}',", sdr["Longitude"]);
                        markers += string.Format("'description': '{0}'", sdr["Description"]);
                        markers += "},";
                    }
                }
                con.Close();
            }

            markers += "];";
            ViewBag.Markers = markers;
            return View();
        }

    }
}
