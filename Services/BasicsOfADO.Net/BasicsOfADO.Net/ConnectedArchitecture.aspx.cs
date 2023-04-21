using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BasicsOfADO.Net
{
    public partial class ConnectedArchitecture : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["DemoCS"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                //Connnected architecture
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from country where cid=@cid";
                //cmd.Parameters.AddWithValue("@cid", 1);
                
                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName= "@cid";
                parameter.Value = 1;
                cmd.Parameters.Add(parameter);
                SqlDataReader dr = cmd.ExecuteReader();
                
                
                while(dr.Read())
                {
                    Response.Write(dr[0]+" " + dr[1]+"<br/>");
                }
            }

        }
    }
}