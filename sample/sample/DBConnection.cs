using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace sample
{
    internal class DBConnection
    {
        static void Main(string[] args)
        {
            SqlConnection conn = new SqlConnection("server=EPINHYDW06EE\\SQLEXPRESS01;database=PracticeDB;integrated security=true");
            conn.Open();
            Console.WriteLine(conn.State);
            conn.Close();
            Console.WriteLine(conn.State);
            Console.ReadLine();
        }

    }
}
