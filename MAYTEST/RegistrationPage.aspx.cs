using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace MAYTEST
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //create the connection to the database
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            connection.Open();
            //create the sql command
            SqlCommand cmd = new SqlCommand("INSERT INTO Pets VALUES ( @Name, @Species)", connection);
            //create the params from the textbox inputs
            cmd.Parameters.AddWithValue("Name", Name.Text);
            cmd.Parameters.AddWithValue("Species", Species.Text);
            //run the command, its not a query because its insert so we need this 
            try
            {
                cmd.ExecuteNonQuery();
                Label1.Visible = true;
                Label1.Text = "Pet registered successfully";
            }
            catch
            {
                Label1.Text = "database error";
            }
            //show that a pet has been added and reset the textboxes
            
            Name.Text = "";
            Species.Text = "";

        }
    }
}