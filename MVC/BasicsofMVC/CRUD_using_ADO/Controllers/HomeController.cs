using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CRUD_using_ADO.Models;

namespace CRUD_using_ADO.Controllers
{
    
    public class HomeController : Controller
    {
        [OutputCache(Duration = 10)]

        public string Index()
        {

            return DateTime.Now.ToString("T");
        }
        [HandleError]

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        [ActionFilter]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [Authorize]
        public ActionResult Secured()
        {
            return View();
        }
        [AllowAnonymous]
        public ActionResult NonSecured()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginModel login)
        {
            return View();
        }
    }
}