using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StoreImages
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["DemoCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("Select * from store_image_2", con); 
                con.Open(); 
                SqlDataReader fdr = cmd.ExecuteReader(); 
                GridView1.DataSource = fdr; 
                GridView1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            byte[] bytes;
            using (BinaryReader br = new BinaryReader(FileUpload1.PostedFile.InputStream))
            {
                bytes = br.ReadBytes(FileUpload1.PostedFile.ContentLength);
            }
            string constr = ConfigurationManager.ConnectionStrings["DemoCS"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(constr))
            {
                string sql = "INSERT INTO store_image_2 VALUES(@Name, @ContentType, @Data)";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", Path.GetFileName(FileUpload1.PostedFile.FileName));
                    cmd.Parameters.AddWithValue("@ContentType", FileUpload1.PostedFile.ContentType);
                    cmd.Parameters.AddWithValue("@Data", bytes);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }

            }
        }
    }
}