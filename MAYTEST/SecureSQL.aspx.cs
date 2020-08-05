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
    public partial class WebForm10 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //connect to the database
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            connection.Open();
            //create the sql command using name as a param
            SqlCommand cmd = new SqlCommand("SELECT id,name,species FROM Pets WHERE name LIKE @Name+ '%'", connection);
            //parameter query to make it secure to sql injection
            cmd.Parameters.AddWithValue("@Name", TextBox1.Text);
            //create the adapter and table
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
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
            
            //if theres data, show it
            if (table.Rows.Count > 0)
            {
                GridView1.DataSource = table;
                GridView1.DataBind();
                Label1.Visible = false;
            }
            else
            {
                //otherwise show no data and a message
                GridView1.DataSource = null;
                GridView1.DataBind();
                Label1.Visible = true;
                Label1.Text = "No pet with that name";

            }
        }
    }
}