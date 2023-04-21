using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace CascadingDropdownLists
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
            SqlConnection sqlconn=new SqlConnection("Data Source=EPINHYDW06EE\\SQLEXPRESS01;Initial Catalog=Practice;Integrated Security=True");
            
            string query = "select * from country";
            SqlCommand sqlcom=new SqlCommand(query,sqlconn);
            sqlconn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(sqlcom);
            SqlDataAdapter adapter2 = new SqlDataAdapter("select * from emp",sqlconn);
            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();
            adapter.Fill(dt);
            adapter2.Fill(dt2);
            comboBox1.ValueMember= "cid";
            comboBox1.DisplayMember = "cname";
            comboBox1.DataSource = dt;
            comboBox2.Enabled= false;
            comboBox3.Enabled= false;
            dgv1.DataSource = dt2;
            sqlconn.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedValue.ToString()!=null)
            {
                string mainCon = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
                SqlConnection sqlconn = new SqlConnection(mainCon);

                string query = "select * from state where cid=@cid";
                SqlCommand sqlcom = new SqlCommand(query, sqlconn);
                sqlconn.Open();
                sqlcom.Parameters.AddWithValue("@cid",comboBox1.SelectedValue.ToString());
                
                SqlDataAdapter adapter = new SqlDataAdapter(sqlcom);
                string query2 = "select * from emp where country=' " + comboBox1.Text.ToString() + " ' ";
               SqlDataAdapter adapter2=new SqlDataAdapter(query2,sqlconn);
                DataTable dt = new DataTable();
                DataTable dt2 = new DataTable();
                
                adapter.Fill(dt);
                adapter2.Fill(dt2);
                comboBox2.ValueMember = "sid";
                comboBox2.DisplayMember = "sname";
                comboBox2.DataSource = dt;
                comboBox2.Enabled = true;
                comboBox3.Enabled = false;
                dgv1.DataSource = dt2;
                sqlconn.Close();

            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedValue.ToString() != null)
            {
                string mainCon = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
                SqlConnection sqlconn = new SqlConnection(mainCon);

                string query = "select * from city where sid=@sid";
                SqlCommand sqlcom = new SqlCommand(query, sqlconn);
                sqlconn.Open();
                sqlcom.Parameters.AddWithValue("@sid", comboBox2.SelectedValue.ToString());
                SqlDataAdapter adapter = new SqlDataAdapter(sqlcom);
                //string query2 = "select * from emp where state=' " + comboBox2.SelectedValue.ToString() + " ' ";
                //adapter2 = new SqlDataAdapter(query2, sqlconn);
                DataTable dt = new DataTable();
               // dt2 = new DataTable();
                adapter.Fill(dt);
                //adapter2.Fill(dt2);
                comboBox3.ValueMember = "cityid";
                comboBox3.DisplayMember = "CityName";
                comboBox3.DataSource = dt;
                comboBox3.Enabled = true;
               // dgv1.DataSource = dt2;
                sqlconn.Close();


            }
        }

    }
}