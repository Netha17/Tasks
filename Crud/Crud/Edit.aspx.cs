using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Crud
{
    public partial class Edit : System.Web.UI.Page
    {
        public int index;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                 index=Convert.ToInt32 (Request.QueryString["sid"].ToString());
                name.Text= Request.QueryString["sname"].ToString();
                mbl.Text = Request.QueryString["mbl"].ToString();
                fee.Text= Request.QueryString["fee"].ToString();
                //fee.Text = index.ToString();


            }
        }

        protected void btnInsertRecord_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source = EPINHYDW06EE\\SQLEXPRESS01; Initial Catalog = Practice; Integrated Security = True")) 
            {
                con.Open();
                //SqlCommand cmd = new SqlCommand("update student_v2 set sname=@name,mobile_no=@mbl,fee=@fee where sid=@id", con);
                SqlCommand cmd = new SqlCommand("update student_v2 set sname='" + name.Text + "',mobile_no='"+ Convert.ToInt64(mbl.Text) + "',fee='"+ Convert.ToDecimal(fee.Text) + "' where sid='"+ Convert.ToInt32(Request.QueryString["sid"]) + "'",con);

                
                int t=cmd.ExecuteNonQuery();

                if(t>0)
                {
                    Response.Write("<script>alert('updated successfully')</script>");
                    
                }
                else
                {
                    Response.Write("<script>alert('Updation failed')</script>");
                }
            }
            Response.Redirect("Homepage.aspx");

        }
    }
}