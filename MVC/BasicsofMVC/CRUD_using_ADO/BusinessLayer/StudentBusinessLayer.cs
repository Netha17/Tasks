using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace CRUD_using_ADO.BusinessLayer
{
    public class StudentBusinessLayer

    {
        string cs = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;
        public void AddStudent(Student s)
        {
            using(SqlConnection conn= new SqlConnection(cs))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert_student", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                
                //add name
                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@name";
                parameter.Value = s.name;
                cmd.Parameters.Add(parameter);

                //add mobile
                SqlParameter parameter1= new SqlParameter();
                parameter1.ParameterName = "@mobile";
                parameter1.Value = s.mobile;
                cmd.Parameters.Add(parameter1);

                //add fee
                SqlParameter parameter2= new SqlParameter();
                parameter2.ParameterName = "@fee";
                parameter2.Value = s.fee;
                cmd.Parameters.Add(parameter2);
                cmd.ExecuteNonQuery();
            }
        }
        public IEnumerable<Student> GetStudents
        {
            get
            {
                List<Student> s = new List<Student>();
                using (SqlConnection conn = new SqlConnection(cs))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("get_students", conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {
                        s.Add(new Student
                        {
                            id = Convert.ToInt16(dr["sid"]),
                            name = Convert.ToString(dr["sname"]),
                            mobile = Convert.ToInt64(dr["mobile_no"]),
                            fee = Convert.ToDouble(dr["fee"])
                        }); ;
                    }



                }
                return s;
            }
         

        
        }
        public void delete_student(int id)
        {
            using(SqlConnection conn = new SqlConnection(cs)) { 
            conn.Open();
                SqlCommand cmd = new SqlCommand("delete from student_v2 where sid='" + id + "'",conn);
                cmd.ExecuteNonQuery();

            }
        }
     

    }
}