using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Npgsql;

namespace CSE412_Group_Project_WebApp
{
    public partial class ViewMyProperties : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int clientID = Convert.ToInt32(Session["clientID"]);
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=TEAM14;User Id=postgres;Password=password");
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandText = "SELECT * FROM house WHERE \"ownerID\"=@id";
            comm.Parameters.AddWithValue("id", clientID);
            NpgsqlDataAdapter nda = new NpgsqlDataAdapter(comm);
            DataTable dt = new DataTable();
            nda.Fill(dt);

            comm.Dispose();
            conn.Close();

            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void manage_Click(object sender, EventArgs e)
        {
            int clientID = Convert.ToInt32(Session["clientID"]);
            int propID = Convert.ToInt32(TextBox1.Text);
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=TEAM14;User Id=postgres;Password=password");
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandText = "SELECT * FROM house WHERE \"ownerID\"=@id AND \"propID\"=@pid";
            comm.Parameters.AddWithValue("id", clientID);
            comm.Parameters.AddWithValue("pid", propID);
            NpgsqlDataReader rdr = comm.ExecuteReader();
            if (rdr.Read())
            {
                comm.Dispose();
                conn.Close();
                conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=TEAM14;User Id=postgres;Password=password");
                conn.Open();
                comm = new NpgsqlCommand();
                comm.Connection = conn;
                comm.CommandText = "DELETE FROM house WHERE \"propID\"=@pid";
                comm.Parameters.AddWithValue("pid", propID);
                comm.ExecuteNonQuery();
                Label3.Text = "Property with id " + propID.ToString() + " successfully deleted";
                conn.Close();
            }
            else
            {
                Label3.Text = "You do not own a property with that property ID, please try a different property!";
            }
            conn.Close();
        }
    }
}