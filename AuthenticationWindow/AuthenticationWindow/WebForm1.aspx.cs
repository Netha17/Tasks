using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AuthenticationWindow
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        Stopwatch stopwatch;


        protected void Page_PreInit(object sender, EventArgs e)
        {
            
        }
        protected void Page_Init(object sender, EventArgs e)
        {
            stopwatch= new Stopwatch();
            stopwatch.Start();
            
        }
        protected void Page_InitComplete(object sender, EventArgs e)
        {
            
        }
        protected void Page_PreLoad(object sender, EventArgs e)
        {
            
        }
     
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Is user authenticated:");
            Response.Write(User.Identity.IsAuthenticated.ToString()+"<br/>");
            Response.Write("Username, if authenticated");
            Response.Write(User.Identity.Name);
            System.Threading.Thread.Sleep(1000);
        }
        protected void Page_PreRender(object sender, EventArgs e)
        {
             stopwatch.Stop();
            TimeSpan timeSpan= stopwatch.Elapsed;
            
            

            Label1.Text = "Page Execution time is " + timeSpan.TotalSeconds + " seconds.";
        }
    }
}