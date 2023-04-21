using System.Data;
using System.Data.SqlClient;

namespace CascadingDropDownlistusingGridview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string connectionString = "Data Source=EPINHYDW06EE\\SQLEXPRESS01;Initial Catalog=Practice;Integrated Security=True";
            
            using (SqlConnection sqlConn = new SqlConnection(connectionString))
            {
                sqlConn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("select * from country", sqlConn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                comboBox1.ValueMember= "cid";
                comboBox1.DisplayMember= "cname";
                comboBox1.DataSource = dt;
                comboBox2.Enabled= false;
                comboBox3.Enabled = false;

                //datagridview
                SqlDataAdapter adapter2 = new SqlDataAdapter("select * from emp", sqlConn);
                DataTable dt2=new DataTable();
                adapter2.Fill(dt2);
                dgv1.DataSource= dt2;

            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString = "Data Source=EPINHYDW06EE\\SQLEXPRESS01;Initial Catalog=Practice;Integrated Security=True";
            if (comboBox1.SelectedValue.ToString() != null)
            {
                using (SqlConnection sqlConn = new SqlConnection(connectionString))
                {
                    sqlConn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter("select * from state where cid= ' "+comboBox1.SelectedValue.ToString()+ " ' ", sqlConn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    comboBox2.ValueMember = "sid";
                    comboBox2.DisplayMember = "sname";
                    comboBox2.DataSource = dt;
                    comboBox2.Enabled = true;
                    comboBox3.Enabled = false;


                    //datagridview
                    string cname=comboBox1.Text.ToString();
                    string query = "select * from emp where country='" + cname + "'";
                    SqlDataAdapter adapter2 = new SqlDataAdapter(query,sqlConn);
                   // MessageBox.Show(cname);
                    DataTable dt2 = new DataTable();
                    adapter2.Fill(dt2);
                    dgv1.DataSource= dt2;

                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString = "Data Source=EPINHYDW06EE\\SQLEXPRESS01;Initial Catalog=Practice;Integrated Security=True";
            if (comboBox2.SelectedValue.ToString() != null)
            {
                using (SqlConnection sqlConn = new SqlConnection(connectionString))
                {
                    sqlConn.Open();
                    
                    SqlDataAdapter adapter = new SqlDataAdapter("select * from city where sid= ' " + comboBox2.SelectedValue.ToString() + " ' ", sqlConn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    comboBox3.ValueMember = "cityid";
                    comboBox3.DisplayMember = "CityName";
                    comboBox3.DataSource = dt;
                    comboBox3.Enabled = true;


                    //datagridview
                    //datagridview
                    string sname = comboBox2.Text.ToString();
                    string query = "select * from emp where state='" + sname + "'";
                    SqlDataAdapter adapter2 = new SqlDataAdapter(query, sqlConn);
                   
                    DataTable dt2 = new DataTable();
                    adapter2.Fill(dt2);
                    dgv1.DataSource = dt2;

                }
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString = "Data Source=EPINHYDW06EE\\SQLEXPRESS01;Initial Catalog=Practice;Integrated Security=True";

            using (SqlConnection sqlConn = new SqlConnection(connectionString))
            {
                sqlConn.Open();
                string cityname = comboBox3.Text.ToString();
                string query = "select * from emp where city='" + cityname + "'";
                SqlDataAdapter adapter2 = new SqlDataAdapter(query, sqlConn);

                DataTable dt2 = new DataTable();
                adapter2.Fill(dt2);
                dgv1.DataSource = dt2;
            }
        }
    }
}