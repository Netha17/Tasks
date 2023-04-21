using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace Crud
{
    public partial class CascadingDropDown : System.Web.UI.Page
    {
      
       
        protected void Page_InitComplete(object sender, EventArgs e)
        {

        }
        protected   void Page_PreLoad(object sender, EventArgs e)
        {
            
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            
            
                using (SqlConnection con = new SqlConnection("Data Source = EPINHYDW06EE\\SQLEXPRESS01; Initial Catalog = Practice; Integrated Security = True"))
                {
                    con.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter("select * from country", con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    ddCountry.DataSource = dt;
                    ddCountry.DataTextField = "cname";
                    ddCountry.DataBind();
                    ListItem li1 = new ListItem("Srilanka");
                    ddCountry.Items.Add(li1);


                }
            
            
            
            
            

               
            

        }


        protected void ddCountry_SelectedIndexChanged1(object sender, EventArgs e)
        {

        }

        protected void ddState_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}