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
using System.Threading;


namespace MAYTEST
{
    
    public partial class BruteForceSleep : System.Web.UI.Page
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
            //fill the table, try catch incase it doesnt exist
            try
            {
                adapter.Fill(table);
            }
            catch
            {
                Label1.Text = "database error";
            }
            

            //if there is data in the table redirect
            if (table.Rows.Count > 0)
            {
                Response.Redirect("LoggedIn.aspx");
            }
            else
            {
                //otherwise show the label and sleep the thread for 5 seconds to prevent it running
                Label1.Visible = true;
                Thread.Sleep(5000);
               

            }

            connection.Close();
        }
    }
}