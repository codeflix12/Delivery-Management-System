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
    public class DriverLogic
    {

        public static DataTable SelectAll()
        {
            string query = "Select * from driverdetails";
            List<SqlParameter> parameters = new List<SqlParameter>();
            return DBHelper.SelectData(query, parameters);
        }

        public static int Update(driverdetails dt)
        {
            string query = "UPDATE driverdetails SET drivername = @drivername,age = @age,mobileno = @mobileno,address = @address,licanceno = @licanceno,vehicleno = @vehicleno,residenceno = @residenceno,familyno = @familyno,relation = @relation,bgroup = @bgroup,bankname = @bankname,acno = @acno,ifsccode = @ifsccode,isactive = @isactive  WHERE id = @ID";
            List<SqlParameter> parameters = new List<SqlParameter>();
          //  parameters.Add(new SqlParameter("@driverid", dt.driverid));
            parameters.Add(new SqlParameter("@id", dt.id));
            parameters.Add(new SqlParameter("@drivername", dt.drivername));
            parameters.Add(new SqlParameter("@age", dt.age));
            parameters.Add(new SqlParameter("@mobileno", dt.mobileno));
            parameters.Add(new SqlParameter("@address", dt.address));
            parameters.Add(new SqlParameter("@licanceno", dt.licanceno));
            parameters.Add(new SqlParameter("@vehicleno", dt.vehicleno));
            parameters.Add(new SqlParameter("@residenceno", dt.residenceno));
            parameters.Add(new SqlParameter("@familyno", dt.familyno));
            parameters.Add(new SqlParameter("@relation", dt.relation));
            parameters.Add(new SqlParameter("@bgroup", dt.bgroup));
            parameters.Add(new SqlParameter("@bankname", dt.bankname));
            parameters.Add(new SqlParameter("@branchname", dt.branchname));
            parameters.Add(new SqlParameter("@acno", dt.acno));
            parameters.Add(new SqlParameter("@ifsccode", dt.ifsccode));
            parameters.Add(new SqlParameter("@isactive", dt.isactive));

            return DBHelper.ModifyData(query, parameters);
        }


        public static int Insert(driverdetails dt)
        {
            string query = "INSERT INTO driverdetails VALUES(@driverid, @drivername,@age, @mobileno, @address,@licanceno,@vehicleno,@residenceno,@familyno,@relation,@bgroup,@bankname,@branchname,@acno,@ifsccode,@isactive)";
            List<SqlParameter> parameters = new List<SqlParameter>();
         //   parameters.Add(new SqlParameter("@Cid", dt.id));

            parameters.Add(new SqlParameter("@driverid", dt.driverid));
            parameters.Add(new SqlParameter("@drivername", dt.drivername));
            parameters.Add(new SqlParameter("@age", dt.age));
            parameters.Add(new SqlParameter("@mobileno", dt.mobileno));
            parameters.Add(new SqlParameter("@address", dt.address));
            parameters.Add(new SqlParameter("@licanceno", dt.licanceno));
            parameters.Add(new SqlParameter("@vehicleno", dt.vehicleno));
            parameters.Add(new SqlParameter("@residenceno", dt.residenceno));
            parameters.Add(new SqlParameter("@familyno", dt.familyno));
            parameters.Add(new SqlParameter("@relation", dt.relation));
            parameters.Add(new SqlParameter("@bgroup", dt.bgroup));
            parameters.Add(new SqlParameter("@bankname", dt.bankname));
            parameters.Add(new SqlParameter("@branchname", dt.branchname));
            parameters.Add(new SqlParameter("@acno", dt.acno));
            parameters.Add(new SqlParameter("@ifsccode", dt.ifsccode));
            parameters.Add(new SqlParameter("@isactive", dt.isactive));

            return DBHelper.ModifyData(query, parameters);

        }


        public static int Delete(driverdetails c)
        {
            string query = "UPDATE Category SET isactive = @isactive WHERE id = @id";
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@isactive", c.isactive));
            parameters.Add(new SqlParameter("@id", c.id));

            return DBHelper.ModifyData(query, parameters);
        }


        public static driverdetails SelectByPK(int ID)
        {
            string query = "SELECT * FROM driverdetails WHERE id = @id";
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@id", ID));
            DataTable dt = DBHelper.SelectData(query, parameters);
            driverdetails d = new driverdetails();
            if (dt.Rows.Count == 0)
            {
                return d;
            }
            else
            {
               
                d.id = ID;
                d.driverid = (Guid)dt.Rows[0]["driverid"];
                d.drivername = dt.Rows[0]["drivername"].ToString();
                d.age = dt.Rows[0]["age"].ToString();
                d.mobileno = dt.Rows[0]["mobileno"].ToString();
                d.address = dt.Rows[0]["address"].ToString();
                d.licanceno = dt.Rows[0]["licanceno"].ToString();
                d.vehicleno = dt.Rows[0]["vehicleno"].ToString();
                d.residenceno = dt.Rows[0]["residenceno"].ToString();
                d.familyno = dt.Rows[0]["familyno"].ToString();
                d.relation = dt.Rows[0]["relation"].ToString();
                d.bgroup = dt.Rows[0]["bgroup"].ToString();
                d.bankname = dt.Rows[0]["bankname"].ToString();
                d.branchname = dt.Rows[0]["branchname"].ToString();
                d.acno = dt.Rows[0]["acno"].ToString();
                d.ifsccode = dt.Rows[0]["ifsccode"].ToString();
                d.isactive = (bool)dt.Rows[0]["isactive"];


                return d;
            }
        }
               
    }
}