using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Net;

namespace MAYTEST
{
    public partial class BruteForce : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //create connection to database
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            //create a new sql command selecting username and password when they put in a valid username and password
            SqlCommand cmd = new SqlCommand("SELECT Username,Password FROM Users WHERE username= @username AND password= @password", connection);
            //create the params for username and password from the input in textboxes
            cmd.Parameters.AddWithValue("@username", Username.Text);
            cmd.Parameters.AddWithValue("@password", Password.Text);
            connection.Open();
            //create a data adapter 
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            //create the datatable to hold the repsonse
            DataTable table = new DataTable();
            //fill the table
            try
            {
                adapter.Fill(table);
            }
            catch
            {
                Label1.Text = "database error";
            }
            
            //if there is data in the table
            if (table.Rows.Count > 0)
            {
                //make a login cookie containing username and password - for a demonstration in XSS
                HttpCookie logincookie = new HttpCookie("Username and Password", "User: " + Username.Text + " Pass:" + Password.Text);
                Response.Cookies.Set(logincookie);

                //redirect
                Response.Redirect("LoggedIn.aspx");
            }
            else
            //the sql was not valid
            {
                Label1.Visible = true;
                Label1.Text = "Incorrect login details";
            }

            connection.Close();
        }
    }
}