using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Crud
{
    public partial class Homepage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridViewLoad();
            }
        }
        void GridViewLoad()
        {
            using (SqlConnection con = new SqlConnection("Data Source=EPINHYDW06EE\\SQLEXPRESS01;Initial Catalog=Practice;Integrated Security=True"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from student_v2", con);
                SqlDataReader dr = cmd.ExecuteReader();
                GridView1.DataSource = dr;
                GridView1.DataBind();
            }

        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if(e.CommandName =="EditButton")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = GridView1.Rows[index];
                Response.Redirect("Edit.aspx?sid=" + row.Cells[1].Text+"&sname=" + row.Cells[2].Text + "&mbl=" + row.Cells[3].Text + "&fee=" + row.Cells[4].Text);
            }
        }

        protected void CbEmpty_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chkstatus = (CheckBox)sender;
            GridViewRow row = (GridViewRow)chkstatus.NamingContainer;
        }

        protected void CbHeader_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chkheader = (CheckBox)GridView1.HeaderRow.FindControl("CbHeader");
            foreach(GridViewRow row in GridView1.Rows)
            {
                CheckBox chkrow =(CheckBox) row.FindControl("CbEmpty");
                if (chkheader.Checked == true)
                {
                    chkrow.Checked = true;
                }
                else
                {
                    chkrow.Checked = false;
                }
            }
        }

     

        protected void btnDelete_Click1(object sender, EventArgs e)
        {
            for (int i = 0; i < GridView1.Rows.Count; i++)
            {
                CheckBox chkdelete = (CheckBox)GridView1.Rows[i].Cells[0].FindControl("CbEmpty");
                if (chkdelete.Checked == true)
                {
                    
                    int id = Convert.ToInt32(GridView1.Rows[i].Cells[1].Text);
                    using (SqlConnection con = new SqlConnection("Data Source=EPINHYDW06EE\\SQLEXPRESS01;Initial Catalog=Practice;Integrated Security=True"))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("delete from student_v2 where sid='" + id + "'", con);
                        int t = cmd.ExecuteNonQuery();
                        if (t > 0)
                        {
                            Response.Write("<script>alert('Deleted')</script>");
                        }
                        else
                        {
                            Response.Write("<script>alert('Not Deleted')</script>");
                        }



                    }
                }
            }
            GridViewLoad();
        }
    }
    //Request.QueryString[sid]
}