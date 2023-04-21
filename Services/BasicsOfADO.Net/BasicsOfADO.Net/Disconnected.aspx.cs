using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BasicsOfADO.Net
{
    public partial class Disconnected : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["DemoCS"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                //Disonnnected architecture
                SqlDataAdapter adapter=new SqlDataAdapter("select * from country",con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                GridView1.DataSource= dt;
                GridView1.DataBind();

                foreach(DataRow dr in dt.Rows)
                {
                    Response.Write(dr["cid"] + " " + dr["cname"] + "</br>");
                }


            }

        }
    }
}