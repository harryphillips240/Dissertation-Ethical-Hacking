using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace MAYTEST
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //when the page loads it will display the most recent comment

            //connect to the database and make the sql statement to fetch comments
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            SqlCommand cmd = new SqlCommand("Select Id,Body,Author from Comments ORDER BY Id DESC ", connection);
            connection.Open();
            //make the adapter and table
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            //fill the table
            adapter.Fill(table);
            // create a datarow, and assign it the first row of the data table
            DataRow row = table.Rows[0];
            //sets the body and author to output to labels
            Body.Text = row[1].ToString();
            Author.Text = row[2].ToString();
            connection.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //on click it will submit the comment
            //connect to database
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            connection.Open();
            //make sql statement
            SqlCommand cmd = new SqlCommand("INSERT INTO Comments (body,author) VALUES ( @Body, @Author)", connection);
            //uses secure params to prevent sql injection
            cmd.Parameters.AddWithValue("Body", TextBox1.Text);
            cmd.Parameters.AddWithValue("Author", DropDownList1.Text);
            //its a non query so we need this line to run it
            cmd.ExecuteNonQuery();
            connection.Close();
            //call page reload to load the comment into most recent comment spot
            Page_Load(sender, e);
        }
    }
}