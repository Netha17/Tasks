using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SqlInjection
{
    public partial class Homepage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void txtBox_TextChanged(object sender, EventArgs e)
        {
            using(SqlConnection con=new SqlConnection("Data Source=EPINHYDW06EE\\SQLEXPRESS01;Initial Catalog=Practice;Integrated Security=True"))
            {
                con.Open();
                DataTable dt=new DataTable();
                  SqlCommand cmd = new SqlCommand("select * from country_2 where cname = '" + txtBox.Text + "'", con);
                
                GridView1.DataSource = cmd.ExecuteReader();
                GridView1.DataBind();
            }

        }
    }
}