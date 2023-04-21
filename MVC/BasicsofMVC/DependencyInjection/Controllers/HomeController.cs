using BussinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DependencyInjection.Controllers
{
    public class HomeController : Controller
    {
        private Employee e;
        public HomeController(Employee e) 
        {
           this.e = e;

        }
        public ActionResult Index()
        {
            ViewBag.Count=e.GetAllEmployees();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}