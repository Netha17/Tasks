using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace Authentication
{
    public partial class Signup : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["practiceDataString"].ConnectionString.ToString();
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_SubmitClick(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into signup(username,email,mobile,password) values('" + txtUsername.Text + "','" + txtEmail.Text.Trim() + "','" + txtMobile.Text + "','" + txtPassword.Text + "')", con);
                int t = cmd.ExecuteNonQuery();
                if (t > 0)
                {
                    Response.Redirect("Anonymous/Login1.aspx");
                }

            }
        }
    }
}