using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Crud
{
    public partial class Cookie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["UserName"] != null)
            {
                Response.Write("Usename from cookie: " + Session["UserName"].ToString());
            }
            if (Session["Pwd"] != null)
            {
                Response.Write("password from cookie: " + Session["Pwd"].ToString());
            }
            if (Application["UserName"] != null)
            {
                Response.Write("Usename from application state varibles: " + Application["UserName"].ToString());
            }
            if (Application["Pwd"] != null)
            {
                Response.Write("password  from application state varibles: " + Application["Pwd"].ToString());
            }




        }
      
        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("myCookie");
            cookie["username"]=TextBox1.Text;
            cookie.Expires = DateTime.Now.AddSeconds(30);
            Response.Cookies.Add(cookie);
            Response.Redirect("HiddenValues2.aspx");
        }

    }
}