using System.Data;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        DataTable dt=new DataTable();
        string name;
        string designation;
        string sal;
        string gender;
        string skills;
        public Form1()
        {
            InitializeComponent();
            dt.Columns.Add("Name");
            dt.Columns.Add("Designation");
            dt.Columns.Add("Salary");
            dt.Columns.Add("Gender");
            dt.Columns.Add("Skills");
        }

        private void button1_Click(object sender, EventArgs e)
        {
           name=txtName.Text;
              designation=txtDesignation.Text;
              sal=txtSalary.Text;
              
            if (rdbtnFemale.Checked)
            {
                gender= "female";

            }
            else
                gender= "Male";
              
            if(chPython.Checked)
            {
                skills = "python";
                if (chJava.Checked)
                {
                    skills += " Java";
                }
                if (chnet.Checked)
                {
                    skills += " .Net";
                }
            }

            display();
            empty();
        }
        public void display()
        {

            DataRow dr = dt.NewRow();
            dr[0] = name;
            dr[1] = designation;
            dr[2] = sal;
            dr[3] = gender;
            dr[4]= skills;
            dt.Rows.Add(dr);    
            dataGridView1.DataSource= dt;
            MessageBox.Show("Data has been added");
        }
        public void empty()
        {
            txtName.Text = "";
            txtDesignation.Text = "";
            txtSalary.Text = "";
        }
    }
}