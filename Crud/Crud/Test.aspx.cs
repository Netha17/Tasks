using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Crud
{
    public partial class Test : System.Web.UI.Page
    {
        
        
        //    protected void Page_PreInit(object sender, EventArgs e)
        //    {

        //    }

        //    protected void Page_Init(object sender, EventArgs e)
        //    {

        //    txtusername.Text = txtusername.Text;
        //    }
        //    protected void Page_InitComplete(object sender, EventArgs e)
        //    {
        //    txtusername.Text = txtusername.Text;
        //        }
        //protected void Page_PreLoad(object sender, EventArgs e)
        //{
        //    txtusername.Text = txtusername.Text+"netha";
        //}
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
            
              //  txtusername.Text = txtusername.Text;
            
            

        }


    

        protected void txtusername_TextChanged(object sender, EventArgs e)
            {
                if (txtusername.Text.Length < 5)
                {
                    Response.Write("username is short");
                }
            }
        }
    }
