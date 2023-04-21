using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Website1
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [Obsolete]
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (FormsAuthentication.Authenticate(txtUsername.Text, txtPassword.Text))
            {
                FormsAuthentication.RedirectFromLoginPage(txtPassword.Text, true);
                
            }
            else
            {
                Response.Write("<script>alert('invalid credentials')</script>");
            }
        }
    }
}