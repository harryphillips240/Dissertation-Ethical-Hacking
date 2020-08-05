using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MAYTEST
{
    public partial class JavaScriptDOMCheck : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the url
            string url = HttpContext.Current.Request.Url.AbsoluteUri;
            //get the param from the url, 47 is chars before the ?
            url = url.Substring(47);

            //if it doesnt have any of the language options and isnt blank
            if (!url.Contains("English") && !url.Contains("French") && !url.Contains("German") && !(url == ""))
            {
                //redirect to default
                Response.Redirect("JavaScriptDOMCheck.aspx");
            }
        }
    }
}