using System.Data;
using System.Data.SqlClient;
namespace demoDataGrid

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getBtn_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=EPINHYDW06EE\\SQLEXPRESS01;Initial Catalog=Practice;Integrated Security=True";
            using(SqlConnection sqlCon=new SqlConnection(connectionString))
            {
                sqlCon.Open();
                DataTable dt= new DataTable();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from country", sqlCon);
                sqlDataAdapter.Fill(dt);
                dgv1.DataSource = dt;

            }
            
        }
    }
}