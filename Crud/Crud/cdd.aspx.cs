using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using Microsoft.AspNet.FriendlyUrls;

namespace Crud
{
    public partial class cdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                using(SqlConnection con=new SqlConnection("Data Source=EPINHYDW06EE\\SQLEXPRESS01;Initial Catalog=Practice;Integrated Security=True"))
                {
                    con.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter("select * from countries",con);
                    DataTable dt= new DataTable();
                    adapter.Fill(dt);
                    ddCountry.DataSource= dt;
                    ddCountry.DataTextField = "cname";
                    ddCountry.DataValueField = "cid";
                    ddCountry.DataBind();
                    ddState.Enabled = false;
                    ddCity.Enabled = false;
                }
                
            }
        }
        protected void Page_Error(object sender, EventArgs e)
        {
            Exception ex=Server.GetLastError();
            //Server.ClearError();
            //Response.Redirect("ExceptionHandler.aspx");

        }

        protected void ddCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=EPINHYDW06EE\\SQLEXPRESS01;Initial Catalog=Practice;Integrated Security=True"))
            {
                int index = Convert.ToInt32(ddCountry.SelectedValue);
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("select * from state where cid='"+index+"'", con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                ddState.DataSource= dt;
                ddState.Enabled = true;
                ddState.DataTextField = "sname";
                ddState.DataValueField = "sid";
                ddState.DataBind();
                ddCity.Enabled = false;
                
            }

        }

        protected void ddState_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=EPINHYDW06EE\\SQLEXPRESS01;Initial Catalog=Practice;Integrated Security=True"))
            {
                int index=Convert.ToInt32(ddState.SelectedValue);
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("select * from city where sid='"+index+"'",con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                ddCity.DataSource= dt;
                ddCity.Enabled= true;
                ddCity.DataTextField = "cityName";
                ddCity.DataValueField = "cityid";
                ddCity.DataBind();
            }
        }
    }
}