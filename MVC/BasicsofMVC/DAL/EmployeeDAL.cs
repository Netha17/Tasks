using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class EmployeeDAL : IDataAccessLayer
    {
        //string cs = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;
        public int GetCountOfEmp()
        {
            using (SqlConnection conn = new SqlConnection("Data Source=EPINHYDW06EE\\SQLEXPRESS01;Initial Catalog=Practice;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select count(*) from emp", conn);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
    }
}
