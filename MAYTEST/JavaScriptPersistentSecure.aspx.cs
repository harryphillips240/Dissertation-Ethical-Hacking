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
    public partial class JavaScriptPersistentCheck : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //connect to database and make sql statement
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT Id,Body,Author FROM Comments ORDER BY Id DESC ", connection);
            connection.Open();
            //make adapter and table, fill it
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            //get the first row
            DataRow row = table.Rows[0];
            String body;
            String author;
            //assign body to label
            body = row[1].ToString();
            //html encode the comment so script wont run
            body = Server.HtmlEncode(body);
            Body.Text = body;
            //assign author to label
            author = row[2].ToString();
            //html author so script wont run
            author = Server.HtmlEncode(author);
            Author.Text = author;

            connection.Close();
        }

        //button to submit and then refresh comments
        protected void Button1_Click(object sender, EventArgs e)
        {
            //connect to database and make statement with params 
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            connection.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Comments (body,author) VALUES ( @Body, @Author)", connection);
            //params from textboxes
            cmd.Parameters.AddWithValue("Body", Comment.Text);
            cmd.Parameters.AddWithValue("Author", DropDownList1.Text);
            //run the statement
            cmd.ExecuteNonQuery();
            connection.Close();
            //call page load to display newest comment
            Page_Load(sender, e);
        }
    }
}