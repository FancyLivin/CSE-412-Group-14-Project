using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Npgsql;



namespace CSE412_Group_Project_WebApp.App_Start
{
    public partial class Login_Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            NpgsqlConnection con = new NpgsqlConnection("Host=localhost;Username=postgres;Password=password;Database=TEAM14");
            con.Open();
            var email = TextBox1.Text;
            var password = TextBox2.Text;
            var cmd = new NpgsqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT \"clientID\" FROM person WHERE email=@email AND pwd=@pwd";
            cmd.Parameters.AddWithValue("email", email);
            cmd.Parameters.AddWithValue("pwd", password);
            NpgsqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                var id = rdr.GetInt32(0);
                Session["clientID"] = id;
                con.Close();
                Response.Redirect("OwnerOrBrowser.aspx");
            }
            else
            {
                Label3.Text = "A match for that email and password was not found, have you registered?";
            }
            con.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }
    }
}