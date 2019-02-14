using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using DeliveryManagement.BusinessLogic;
using DeliveryManagement.Models;
using DeliveryManagement.DataAccess;
using System.Data;

namespace DeliveryManagement.BusinessLogic
{
    public class AdminLogic
    {
        public static admin SelectByUnPw(string Username, string Password)
        {
            string query = "SELECT * FROM admin WHERE Username = @Username AND Password = @Password";
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@Username", Username));
            parameters.Add(new SqlParameter("@Password", Password));
            DataTable dt = DBHelper.SelectData(query, parameters);

            admin s = new admin();
            if (dt.Rows.Count > 0)
            {
                s.userid = Convert.ToInt32(dt.Rows[0]["userid"].ToString());
                
                s.username = dt.Rows[0]["username"].ToString();
                s.password = dt.Rows[0]["password"].ToString();
                
            }
            return s;
        }

    }
}