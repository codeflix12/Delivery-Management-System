using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace OnlineShoppingWebApp1.DataAccess
{
    public class DBHelper
    {
        public static int ModifyData(string query, List<SqlParameter> parameters)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source=LAPTOP-CELLHC4D;Initial Catalog=Delivery;Persist Security Info=True;User ID=sa;Password=root;MultipleActiveResultSets=True;Application Name=EntityFramework";
            SqlCommand command = new SqlCommand(query, connection);
            for (int i = 0; i < parameters.Count; i++)
            {
                if(parameters[i].Value == null)
                {
                    parameters[i].Value = DBNull.Value;
                }

                command.Parameters.Add(parameters[i]);
            }
            connection.Open();
            int x = command.ExecuteNonQuery();
            connection.Close();

            return x;
        }

        public static DataTable SelectData(string query, List<SqlParameter> parameters)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source=LAPTOP-CELLHC4D;Initial Catalog=Delivery;Persist Security Info=True;User ID=sa;Password=root;MultipleActiveResultSets=True;Application Name=EntityFramework";
            SqlCommand command = new SqlCommand(query, connection);
            for (int i = 0; i < parameters.Count; i++)
            {
                if (parameters[i].Value == null)
                {
                    parameters[i].Value = DBNull.Value;
                }

                command.Parameters.Add(parameters[i]);
            }
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            connection.Open();
            adapter.Fill(dt);
            connection.Close();

            return dt;
        }
    }
}