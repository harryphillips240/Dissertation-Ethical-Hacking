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
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //create connection to database
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            //create sql command using textbox input
            SqlCommand cmd = new SqlCommand("SELECT id,name,species FROM Pets WHERE name LIKE '" + Name.Text + '%' + "'", connection);
            connection.Open();
            //create the adapter and table
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            //Try catch so it doesnt crash site
            try
            {
                adapter.Fill(table);
            }
            catch
            {
                Label1.Visible = true;
                Label1.Text = "Database error";
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