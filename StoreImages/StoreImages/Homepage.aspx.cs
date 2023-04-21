using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StoreImages
{
    public partial class Homepage : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["DemoCS"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = string.Empty;
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                SqlDataAdapter adapter= new SqlDataAdapter("select * from store_images",con);
                DataTable dt= new DataTable();
                adapter.Fill(dt);
                GridView1.DataSource= dt;
                GridView1.DataBind();

                

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(FileUpload1.HasFile)
            {
                string extension=System.IO.Path.GetExtension(FileUpload1.FileName);
                if (extension.ToUpper() != ".JPG" && extension.ToUpper() != ".GIF" && extension.ToUpper() != ".PNG" && extension.ToUpper() != ".JPEG" && extension.ToUpper() != ".BMP")

                {

                    Label1.Text = "Upload JPG/PNG/JPEG images only.";

                    Label1.ForeColor = System.Drawing.Color.Red;

                    return;

                }
                else
                {
                    Label1.Text = "";
                    string name=FileUpload1.FileName;
                    string fileLocation = @"C:\Users\Nithin_Ale\Desktop\Images";
                    string path = System.IO.Path.Combine(fileLocation,name);
                    Response.Write(path);
                    FileUpload1.SaveAs(path);
                    using(SqlConnection con=new SqlConnection(cs))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("insert into store_images(path) values('" + path + "')", con);
                        int n=cmd.ExecuteNonQuery();
                        if(n > 0)
                        {
                            Label1.Text = "Saved Successfully";
                            Label1.ForeColor= System.Drawing.Color.Green;
                        }
                        else
                        {
                            Label1.Text = "Didn't save..Try Again-";
                            Label1.ForeColor=System.Drawing.Color.Red;
                        }
                    }
                }

            }
        }
    }
}