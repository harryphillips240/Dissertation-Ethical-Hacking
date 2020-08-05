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
    public partial class JavaScriptPersistentCheck1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //connect to database and make sql statement
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT Id,Body,Author FROM Comments ORDER BY Id DESC ", connection);
            connection.Open();
            //create table and adapter
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            //fill table
            adapter.Fill(table);
            //make a datarow and set it to first row of table
            DataRow row = table.Rows[0];
            //assign body and author to labels
            Body.Text = row[1].ToString();
            Author.Text = row[2].ToString();
            connection.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //validation, setting it to upper case and checking
            if (Comment.Text.ToUpper().Contains("<script>") || Comment.Text.ToUpper().Contains("<SCRIPT>"))
            {
                Comment.Text = "Script detected";
            }
            else
            //otherwise run the statement
            {
                //connect to database and make statement
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
                connection.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Comments (body,author) VALUES ( @Body, @Author)", connection);
                //make params from textbox input, sqli secure
                cmd.Parameters.AddWithValue("Body", Comment.Text);
                cmd.Parameters.AddWithValue("Author", DropDownList1.Text);
                //run command
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            //call page load to display newest comment
            Page_Load(sender, e);
        }
    }
}