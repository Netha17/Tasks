using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace Crud
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            Application["count"] = 0;
        }
        void Application_End(object sender, EventArgs e)
        {
            //code that runs on application shutdown
        }
        void Session_Start(object sender, EventArgs e)
        {
            //code that runs when a new session is started
            Application["count"] = (int)Application["count"]+1;
            Session["name"] = "Guest";

        }
        void Application_Error(object sender, EventArgs e)
        {
            //Exception ex = Server.GetLastError();
            //Server.ClearError();
            //Response.Redirect("ExceptionHandler.aspx");
        }



    }
}