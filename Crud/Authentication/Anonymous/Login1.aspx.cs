using Microsoft.Owin.Security.Google;
using Owin;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Authentication
{
    public partial class Login : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["practiceDataString"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if(Check_user())
            {
                HttpCookie mycookie = new HttpCookie("democookie");
                mycookie["username"]=txtUsername.Text.Trim();
                
                mycookie.Expires= DateTime.Now.AddMinutes(1);
                Response.Cookies.Add(mycookie);
                FormsAuthentication.RedirectFromLoginPage(txtUsername.Text.Trim(), true);
            }
            else
            {
                Response.Write("<script>alert('Invalid credentials')</script>");
            }
        }
        bool Check_user()
        {
            using (SqlConnection con=new SqlConnection(cs))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select id from signup where username='"+txtUsername.Text.Trim()+"' and password='"+txtPassword.Text.Trim()+"'",con);
                SqlDataReader rd=cmd.ExecuteReader();
                int count = 0;
                while(rd.Read())
                {
                    count++;
                }
                if(count> 0)
                {
                    return true;
                }
                else
                {
                    return false; 
                }
            }

        }

        //protected void Button1_Click(object sender, EventArgs e)
        //{
        //     void ConfigureAuth(IAppBuilder app)
        //    {
        //        app.UseGoogleAuthentication(new GoogleOAuth2AuthenticationOptions()
        //        {
        //            ClientId = "822596210982-57633lqhn9a9lcie14kl7696233u8med.apps.googleusercontent.com",
        //            ClientSecret = "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"
        //        });
        //    }
        //}
    }
}