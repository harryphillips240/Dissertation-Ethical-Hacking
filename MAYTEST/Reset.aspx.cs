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

namespace MAYTEST.Content
{
    public partial class Reset : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //connect to the database
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
            SqlCommand cmd;
            connection.Open();
            //string that will contain the sql
            String text;

            //you need these try catches in case you try and drop tables that arent there, you need one for each table
            try
            {
                //delete table users
                text = "DROP TABLE Users";
                cmd = new SqlCommand(text, connection);
                cmd.ExecuteNonQuery();

            }
            catch 
            {
                Label1.Visible = true;
                Label1.Text = "Users doesnt exist";
            }

            try
            {
                //delete table comments
                text = "DROP TABLE Comments";
                cmd = new SqlCommand(text, connection);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Label1.Visible = true;
                Label1.Text = "Comments doesnt exist";
            }

            try
            {
                //delete table comments
                text = "DROP TABLE Pets";
                cmd = new SqlCommand(text, connection);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Label1.Visible = true;
                Label1.Text = "Pets doesnt exist";
            }
            


            //Create table Users
            text = "CREATE TABLE Users ([id]INT NOT NULL IDENTITY(1,1),[username]NVARCHAR(40)NOT NULL,[password]NVARCHAR(40)NOT NULL)";
            cmd = new SqlCommand(text, connection);
            cmd.ExecuteNonQuery();
            
            // Fill table
            text = "INSERT INTO Users (username,password) VALUES ('username','password'),('admin','admin'),('harry','123'),('user','pass'),('abc','123') ";
            cmd = new SqlCommand(text, connection);
            cmd.ExecuteNonQuery();


            //Create table Comments
            text = "CREATE TABLE Comments ([id]INT NOT NULL IDENTITY(1,1),[body]NVARCHAR(255)NOT NULL,[author]NVARCHAR(40)NOT NULL)";
            cmd = new SqlCommand(text, connection);
            cmd.ExecuteNonQuery();

            // Fill table
            text = "INSERT INTO Comments (body,author) VALUES ('Example Comment', 'username'),('This is a comment', 'admin'),('Hi im harry','harry')";
            cmd = new SqlCommand(text, connection);
            cmd.ExecuteNonQuery();

            //Create table Pets
            text = "CREATE TABLE Pets ([id]INT NOT NULL IDENTITY(1,1),[name]NVARCHAR(40)NOT NULL,[species]NVARCHAR(255)NOT NULL)";
            cmd = new SqlCommand(text, connection);
            cmd.ExecuteNonQuery();

            // Fill table
            text = "INSERT INTO Pets (name,species) VALUES ('Barry', 'Turtle'),('Jeff', 'Rat'),('Bill', 'Dog'),('Spitfire', 'Sheep') ";
            cmd = new SqlCommand(text, connection);
            cmd.ExecuteNonQuery();


            connection.Close();
        }


    }
}