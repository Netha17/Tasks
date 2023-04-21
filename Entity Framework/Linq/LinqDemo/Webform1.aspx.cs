using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LinqDemo
{
    public partial class Webform1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var resultSet= from obj in Student.GetAllStudent() select obj;
            GridView1.DataSource= resultSet;
            GridView1.DataBind();
        }
    }
}