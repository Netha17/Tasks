using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Crud
{
    public partial class Validations : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            //if(previousPage.IsCrossPagePostBack) 
            //{
            //    TextBox t= (TextBox)PreviousPage.FindControl("txtusername");
            //    Response.Write(t.Text);

            //}
            
        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            int len=args.Value.Length;
            if(len>8 && len<15)
            {
                args.IsValid= true;
            }
            else
            {
                args.IsValid= false;    
            }
        }
    }
}