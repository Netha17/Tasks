using Microsoft.AspNetCore.Mvc;

namespace MVCSetup.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "This is the index action from MVC Home Controller";
        }
    }
}
