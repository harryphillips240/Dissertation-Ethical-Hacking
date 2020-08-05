using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MAYTEST
{
    public partial class JavaScriptRelectedCheck : System.Web.UI.Page
    {
        String language;
        protected void Page_Load(object sender, EventArgs e)
        {
            //checks if script has been added to the url
            //assign language to the url
            language = Server.UrlDecode(Request.Url.Query);
            //if it contains SCRIPT
            if (language.ToUpper().Contains("<script>") || language.ToUpper().Contains("<SCRIPT>")){
                Response.Redirect("JavaScriptReflectedCheck.aspx");
            }


            //empty the label
            Label1.Text = "";
            //check the textbox for SCRIPT, its set to upper to work around ScRiPt
            if (TextBox1.Text.ToUpper().Contains("<script>") || TextBox1.Text.ToUpper().Contains("<SCRIPT>"))
            {
                language = "";
            }
            else
            {
                language = TextBox1.Text;
            }

            
            //get the param from the url
            String output = Server.UrlDecode(Request.Url.Query);
            //get rid of the '?language=' part
            output = output.Split('?').Last();
            //print out the selected language
            Label1.Text = "Selected " + output;

            if (output == "language=English")
            {
                Flag.Visible = true;
                Flag.ImageUrl = "Content\\Images\\englishflag.jpg";
            }
            else if (output == "language=German")
            {
                Flag.Visible = true;
                Flag.ImageUrl = "Content\\Images\\germanflag.jpg";
            }
            else if (output == "language=French")
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
            //redirect to the url with param added on
            Response.Redirect("JavaScriptReflectedCheck.aspx?language=" + language);  
        }
    }
}