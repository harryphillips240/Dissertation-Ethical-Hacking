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
   
    public partial class WebForm9 : System.Web.UI.Page
    {
        
        

        protected void Page_Load(object sender, EventArgs e)
        {
           
            Options.Style.Add("display", "none");
            
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            SqlCommand cmd = new SqlCommand("Select * from Pets where name= '" + Options.Text + "'", conn);
            conn.Open();
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            try
            {
                ad.Fill(dt);
            }
            catch
            {
                Label1.Visible = true;
                Label1.Text = "database error";
            }
            
    
            if (dt.Rows.Count > 0)
            {
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            

            conn.Close();
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Options.Text = DropDownList1.SelectedValue;
            
        }
    }
}