using Catering.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Catering.Controllers
{
    
    public class OrderController : Controller
    {
        public string connstring = ConfigurationManager.ConnectionStrings["PracticeCS"].ConnectionString;
        // GET: Order
        public ActionResult Index()
        {
            return View();
        }

        // GET: Order/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Order/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Order/Create
        [HttpPost]
        public ActionResult Create(OrderModel model)
        {
            try
            {
                using(SqlConnection con=new SqlConnection(connstring))
                {
                    con.Open();
                    SqlCommand sqlCommand= new SqlCommand("spOrdersInsert", con);
                    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    //name
                    SqlParameter para1 = new SqlParameter();
                    para1.ParameterName = "@name";
                    para1.Value = model.Username;
                    sqlCommand.Parameters.Add(para1);
                    //date
                    SqlParameter para2 = new SqlParameter();
                    para2.ParameterName = "@order_date";
                    para2.Value = model.Date;
                    sqlCommand.Parameters.Add(para2);
                    //mobile
                    SqlParameter para3 = new SqlParameter();
                    para3.ParameterName = "@mobile";
                    para3.Value = model.Phonenumber;
                    sqlCommand.Parameters.Add(para3);
                    //email
                    SqlParameter para4 = new SqlParameter();
                    para4.ParameterName = "@email";
                    para4.Value = model.Email;
                    sqlCommand.Parameters.Add(para4);

                    int t=sqlCommand.ExecuteNonQuery();
                    if (t > 0)
                    {
                        return RedirectToAction("Welcome");
                    }

                }

                return View(model);
            }
            catch
            {
                return View();
            }
        }

        // GET: Order/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Order/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Order/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Order/Delete/5
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
     
        public ActionResult Welcome()
        {
            return View();
        }
    }
}
