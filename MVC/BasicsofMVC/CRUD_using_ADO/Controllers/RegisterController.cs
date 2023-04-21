using CRUD_using_ADO.BusinessLayer;
using CRUD_using_ADO.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace CRUD_using_ADO.Controllers
{
    public class RegisterController : Controller
    {
        string cs = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;
        // GET: Register
        public ActionResult Index()
        {
            StudentBusinessLayer studentBusinessLayer = new StudentBusinessLayer();
            List<Student> li = studentBusinessLayer.GetStudents.ToList();
            return View(li);
        }

        // GET: Register/Details/5
        public ActionResult Details(int id)
        {
            Student student = new Student();
            using (SqlConnection conn = new SqlConnection(cs))
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("select * from student_v2 where sid='" + id + "'", conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                
                
                    student.id = Convert.ToInt16(dt.Rows[0]["sid"]);
                    student.name = dt.Rows[0]["sname"].ToString();
                    student.fee = Convert.ToDouble(dt.Rows[0]["fee"]);
                    student.mobile = Convert.ToInt64(dt.Rows[0]["mobile_no"]);
                    
                


            }

            return View(student);
        }
        [HttpGet]
        // GET: Register/Create
        public ActionResult Create()
        {
            return View();
        }


        // POST: Register/Create
        //[HttpPost]
        //public ActionResult Create(FormCollection collection)
        //{

        //    Student student = new Student();
        //    student.name= collection["Name"];
        //    student.mobile = Convert.ToInt64(collection["Mobile"]);
        //    student.fee = Convert.ToDouble(collection["fee"]);
        //    StudentBusinessLayer studentBusinessLayer = new StudentBusinessLayer();
        //    studentBusinessLayer.AddStudent(student);
        //    return RedirectToAction("Index");


        //}
        [HttpPost]
        public ActionResult Create(Student s)
        {

          
            StudentBusinessLayer studentBusinessLayer = new StudentBusinessLayer();
            studentBusinessLayer.AddStudent(s);
            
            return RedirectToAction("Index");


        }
        [HttpGet]

        // GET: Register/Edit/5
        public ActionResult Edit(int id)
        {
            Student student = new Student();
            using(SqlConnection conn=new SqlConnection(cs))
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("select * from student_v2 where sid='" + id + "'", conn);
                DataTable dt= new DataTable();
                adapter.Fill(dt);
                if(dt.Rows.Count==1)
                {
                    student.id = Convert.ToInt16(dt.Rows[0]["sid"]);
                    student.name = dt.Rows[0]["sname"].ToString();
                    student.fee = Convert.ToDouble(dt.Rows[0]["fee"]);
                    student.mobile = Convert.ToInt64(dt.Rows[0]["mobile_no"]);
                    return View(student);
                }
                
            }

            return RedirectToAction("Index");
        }

        // POST: Register/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            using(SqlConnection conn=new SqlConnection(cs))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("update_student", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //add name
                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@name";
                parameter.Value = collection["name"] ;
                cmd.Parameters.Add(parameter);

                //add mobile
                SqlParameter parameter1 = new SqlParameter();
                parameter1.ParameterName = "@mobile";
                parameter1.Value = Convert.ToInt64(collection["Mobile"]);
                cmd.Parameters.Add(parameter1);

                //add fee
                SqlParameter parameter2 = new SqlParameter();
                parameter2.ParameterName = "@fee";
                parameter2.Value = Convert.ToDouble(collection["fee"]);
                cmd.Parameters.Add(parameter2);
                //add id
                SqlParameter parameter3 = new SqlParameter();
                parameter3.ParameterName = "@id";
                parameter3.Value = id;
                cmd.Parameters.Add(parameter3);
                cmd.ExecuteNonQuery();

            }
            return RedirectToAction("Index");
          
        }

        // GET: Register/Delete/5
        public ActionResult Delete(int id)
        {
         StudentBusinessLayer studentBusinessLayer = new StudentBusinessLayer();
            studentBusinessLayer.delete_student(id);
                return RedirectToAction("Index");
        }

        // POST: Register/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
