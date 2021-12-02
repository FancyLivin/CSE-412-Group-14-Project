using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Npgsql;
using System.Data;

namespace CSE412_Group_Project_WebApp
{
    public partial class BuyerOrRenter : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void buyerButton_Click(object sender, EventArgs e)
        {

            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=TEAM14;User Id=postgres;Password=password");
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;

            comm.CommandText = "SELECT \"clientID\" FROM buyer WHERE \"clientID\"=@cI";
            comm.Parameters.Add(new NpgsqlParameter("@cI", int.Parse(Session["clientID"].ToString())));
            NpgsqlDataReader rdr = comm.ExecuteReader();
            if (rdr.Read())
            {
          //      var id = rdr.GetInt32(0);
                conn.Close();
                Response.Redirect("BuyerPreference.aspx");
            }
            else
            {
                conn.Close();
                conn.Open();
                comm.CommandText = "INSERT INTO buyer VALUES(@cI,-100,0,0,0,\'locP\',\'styleP\')";
                comm.Parameters.Add(new NpgsqlParameter("@cI", int.Parse(Session["clientID"].ToString())));
                comm.ExecuteNonQuery();
                comm.Dispose();
                conn.Close();
                Response.Redirect("BuyerPreference.aspx");
            }

            
        }

        protected void renterButton_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=TEAM14;User Id=postgres;Password=password");
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;

            comm.CommandText = "SELECT \"clientID\" FROM renter WHERE \"clientID\"=@cI";
            comm.Parameters.Add(new NpgsqlParameter("@cI", int.Parse(Session["clientID"].ToString())));
            NpgsqlDataReader rdr = comm.ExecuteReader();
            if (rdr.Read())
            {
                //      var id = rdr.GetInt32(0);
                conn.Close();
                Response.Redirect("RenterPreference.aspx");
            }
            else
            {
                conn.Close();
                conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=TEAM14;User Id=postgres;Password=password");
                conn.Open();
                comm = new NpgsqlCommand();
                comm.Connection = conn;
                comm.CommandText = "INSERT INTO renter VALUES(@cI,10000,0,0,0,0,\'locP\',\'styleP\')";
                comm.Parameters.Add(new NpgsqlParameter("@cI", int.Parse(Session["clientID"].ToString())));
                comm.ExecuteNonQuery();
                comm.Dispose();
                conn.Close();
                Response.Redirect("RenterPreference.aspx");
            }


       /*     comm.CommandText = "INSERT INTO renter VALUES(@cI,10000,0,0,0,0,\'locP\',\'styleP\')";
            comm.Parameters.Add(new NpgsqlParameter("@cI", int.Parse(Session["clientID"].ToString())));
            comm.ExecuteNonQuery();
            comm.Dispose();
            conn.Close();
            Response.Redirect("RenterPreference.aspx");*/
        }
    }
}