using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Postbackurl
{
    public partial class Demo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page prevpage = Page.PreviousPage;
            if (prevpage != null)
            {
                TextBox t = (TextBox)prevpage.FindControl("TextBox1");
                Label1.Text = t.Text;
            }
        }
    }
}