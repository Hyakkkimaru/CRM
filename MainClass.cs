using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
    internal class MainClass
    {
        public static readonly string con_string = @"Data source=DESKTOP-S6C459L\CRM_SERVER;Initial Catalog=RM; Integrated Security=True; User ID=sa; Password=123;";
        public static SqlConnection con = new SqlConnection(con_string);

        public static bool IsValidUser(string user, string pass)
        {
            bool isValid = false;
            string req = @"Select * from users where username ='" +user+ "' and upass ='" +pass+ "' ";
            SqlCommand cmd = new SqlCommand(req, con);
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);

            if (dt.Rows.Count > 0 ) { isValid = true; }


            return isValid;
        }
    }
}
