using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Crud
{
    public partial class Postbackurl : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page prevPage = Page.PreviousPage;
            if (prevPage != null)
            {
                Response.Write("hello");
            }
            
        }
    }
}