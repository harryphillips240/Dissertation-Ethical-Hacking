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
using System.IO;

namespace MAYTEST
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            //create connection to database
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            //create a new sql command selecting id, name and species from pets when name starts with input 
            SqlCommand cmd = new SqlCommand("SELECT id,name,species FROM Pets WHERE name LIKE '" + Name.Text + '%' + "'", connection);
            connection.Open();
            //create the data adapter
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            //create the table to hold the response
            DataTable table = new DataTable();
            //Try catch so it doesnt crash site if invalid 
            try
            {
                adapter.Fill(table);

            }
            catch
            {
                Label1.Visible = true;
                Label1.Text = "Database error";
            }
            //if theres data
            if (table.Rows.Count > 0)
            {
                //assign the grid to the database
                GridView1.DataSource = table;
                //bind the data
                GridView1.DataBind();
                Label1.Visible = false;
            }
            else
            {
                //otherwise show no data
                GridView1.DataSource = null;
                GridView1.DataBind();
                Label1.Visible = true;
                Label1.Text = "No pet with that name";
            }

            connection.Close();
        }
    }
}