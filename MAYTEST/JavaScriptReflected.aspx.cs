using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MAYTEST
{
    public partial class JavaScriptReflected : System.Web.UI.Page
    {

        String language;
        protected void Page_Load(object sender, EventArgs e)
        {
            //empty the label
            Label1.Text = "";
            //make language the textbox value
            language = TextBox1.Text;
            //get the param from the url
            String output = Server.UrlDecode(Request.Url.Query);
            //get rid of the '?language=' part
            output = output.Split('=').Last();
            //print out the selected language
            Label1.Text = "Selected language: " + output;
            //find the output and change image to corresponding flag
            if (output == "English")
            {
                Flag.Visible = true;
                Flag.ImageUrl = "Content\\Images\\englishflag.jpg";
            }
            else if (output == "German")
            {
                Flag.Visible = true;
                Flag.ImageUrl = "Content\\Images\\germanflag.jpg";
            }
            else if (output == "French")
            {
                Flag.Visible = true;
                Flag.ImageUrl = "Content\\Images\\frenchflag.jpg";
            }
            else
            {
                Flag.Visible = false;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //redirect to the url with the variable appended on
            Response.Redirect("JavaScriptReflected.aspx?language=" + language);
        }


    }
}

