﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Areas.Areas.Student.Controllers
{
    public class HomeController : Controller
    {
        // GET: Student/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}