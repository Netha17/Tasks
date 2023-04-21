using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;

namespace DropdownUsingAjax.DAL
{
    public class DataAccessLayer
    {
        string cs = ConfigurationManager.ConnectionStrings["DemoCS"].ConnectionString;
        public DataTable Countries()
        {
            using(SqlConnection con= new SqlConnection(cs))
            {
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("select * from country", con);
                DataTable dt= new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
        public DataTable States(string country_id)
        {
            using(SqlConnection con=new SqlConnection(cs))
            {
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("select * from state where cid='" + country_id + "'", con);
                DataTable dt= new DataTable();
                adapter.Fill(dt);
                return dt;
            }

        }
        public DataTable Cities(string state_id)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("select * from city where sid='" + state_id + "'", con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
    }
}