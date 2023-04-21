using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CrudWithMVCOnAccount.Models
{
    public static class TokenFiledHelper
    {
       public static MvcHtmlString tokenField(this HtmlHelper Html)
        {
            string tokenFieldtag = @"<input type=""text"" class=""form-control"" id=""tokenfield"" value=""red,green,blue"" />";
            return new MvcHtmlString(tokenFieldtag);
        }
    }
}