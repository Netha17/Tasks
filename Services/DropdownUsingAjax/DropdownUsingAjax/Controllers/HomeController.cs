using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;
using DropdownUsingAjax.DAL;

namespace DropdownUsingAjax.Controllers
{
  
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            GetCountries();
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
        public void GetCountries()
        {
            DataAccessLayer accessLayer= new DataAccessLayer();
            DataTable dt=accessLayer.Countries();
            List<SelectListItem> countryList = new List<SelectListItem>();
            foreach(DataRow dr in dt.Rows)
            {
                countryList.Add(new SelectListItem { Text = dr["cname"].ToString(), Value = dr["cid"].ToString() });
            }

            ViewBag.Country=countryList;
            
        }
        public JsonResult GetStates(string cid)
        {
            DataAccessLayer accessLayer = new DataAccessLayer();
            DataTable dt = accessLayer.States(cid);
            List<SelectListItem> stateList=new List<SelectListItem>();
            foreach(DataRow dr in dt.Rows)
            {
                stateList.Add(new SelectListItem { Text = dr["sname"].ToString(), Value = dr["sid"].ToString() });
            
            }
            return Json(stateList,JsonRequestBehavior.AllowGet);

        }
        public JsonResult GetCities(string sid)
        {
            DataAccessLayer accessLayer = new DataAccessLayer();
            DataTable dt = accessLayer.Cities(sid);
            List<SelectListItem> cityList = new List<SelectListItem>();
            foreach(DataRow dr in dt.Rows)
            {
                cityList.Add(new SelectListItem { Text = dr["CityName"].ToString(), Value = dr["cityid"].ToString() });
            
            }
            return Json(cityList,JsonRequestBehavior.AllowGet);

        }
    }
}