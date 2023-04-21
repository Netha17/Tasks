using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Crud
{
    public partial class Sessions : System.Web.UI.Page
    {
        protected void Page_PreInit(object sender, EventArgs e)
        {
            Response.Write("Page_preinit" + "<br/>");
            Response.Write("Your name is" + tbUserName.Text);
            tbpwd.Text = "123445";
        }
        protected void Page_Init(object sender, EventArgs e)
        {
            Response.Write("Page_init" + "<br/>");
            Response.Write("Your name is" + tbUserName.Text);
           // tbpwd.Text = "123445";

        }
        protected void Page_InitComplete(object sender, EventArgs e)
        {
            Response.Write("Page_initcomplete" + "<br/>");
            Response.Write("Your name is" + tbUserName.Text);
        }
        protected void Page_PreLoad(object sender, EventArgs e)
        {
            Response.Write("Page_preload" + "<br/>");
            Response.Write("Your name is" + tbUserName.Text);
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Page_load" + "<br/>");
            Response.Write("Your name is" + tbUserName.Text);
        }
        protected void Page_LoadComplete(object sender, EventArgs e)
        {
            Response.Write("Page_loadcomplete" + "<br/>");
            Response.Write("Your name is" + tbUserName.Text);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //textbox value is stored in Session
            Session["UserName"] = tbUserName.Text;
            Session["Pwd"] = tbpwd.Text;
            Application["Username"]=tbUserName.Text;
            Application["Pwd"]=tbpwd.Text;
            Response.Redirect("Cookie.aspx");

        }

        protected void tbUserName_TextChanged(object sender, EventArgs e)
        {
            if (tbUserName.Text.Length < 5)
                Response.Write("<script>alert('Invalid name')</script>");
        }
    }
}