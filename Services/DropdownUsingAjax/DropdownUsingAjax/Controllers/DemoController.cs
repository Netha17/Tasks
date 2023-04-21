using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DropdownUsingAjax.Controllers
{
    [RoutePrefix("Student")]
    public class DemoController : Controller
    {
        // GET: Demo
        [Route]
        public ActionResult Index()
        {
            return View();
        }
        [Route("About")]
        public ActionResult About()
        {
            return View();
        }
        [Route("Welcome/{name}")]
        public ActionResult Welcome(string name)
        {
            ViewBag.Name = name;
            return View();
        }
    }
}