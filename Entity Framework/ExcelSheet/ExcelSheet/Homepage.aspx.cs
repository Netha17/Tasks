using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExcelSheet
{
    public partial class Homepage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public static string path = @"C:\Users\Nithin_Ale\source\repos\Entity Framework\ExcelSheet\ExcelSheet\Excel\Countries.xlsx";
        public static string connStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+path+";Extended Properties=Excel 12.0";

        protected void Button1_Click(object sender, EventArgs e)
        {
            OleDbConnection oleDb=new OleDbConnection(connStr);
            OleDbCommand cmd=new OleDbCommand("select cid,cname from [Sheet1$]",oleDb);
            OleDbDataAdapter adapter =new OleDbDataAdapter(cmd);
            DataSet ds= new DataSet();
            adapter.Fill(ds);
            oleDb.Open();
            DbDataReader dr=cmd.ExecuteReader();
            string cs = ConfigurationManager.ConnectionStrings["DemoCS"].ConnectionString;
            SqlBulkCopy insert=new SqlBulkCopy(cs);
            insert.DestinationTableName = "country";
            insert.WriteToServer(dr);
            oleDb.Close();
            Label1.Text = "succcess";


        }
    }
}