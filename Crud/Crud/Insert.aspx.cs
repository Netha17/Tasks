using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Crud
{
    public partial class Insert : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnInsertRecord_Click(object sender, EventArgs e)
        {
            using (SqlConnection con=new SqlConnection("Data Source=EPINHYDW06EE\\SQLEXPRESS01;Initial Catalog=Practice;Integrated Security=True"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into student_v2(sname,mobile_no,fee) values('" + name.Text + "','" + mbl.Text + "','" + fee.Text + "')", con);
                int t=cmd.ExecuteNonQuery();
                if (t > 0)
                {
                    Response.Write("    <script>alert('Data has added')</script>");
                }
                con.Close();
                clear();
                Response.Redirect("Homepage.aspx");

            }
        }
        void clear()
        {
            name.Text = "";
            mbl.Text = "";
            fee.Text = "";
        }
    }
}