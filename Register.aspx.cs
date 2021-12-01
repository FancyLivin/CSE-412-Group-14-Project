using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Npgsql;

namespace CSE412_Group_Project_WebApp
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submitButton2_Click(object sender, EventArgs e)
        {
            string firstName = TextBox1.Text;
            string lastName = TextBox2.Text;
            string phoneNumber = TextBox3.Text;
            string email = TextBox4.Text;
            string password = TextBox5.Text;

            NpgsqlConnection con = new NpgsqlConnection("Host=localhost;Username=postgres;Password=password;Database=TEAM14");
            con.Open();
            var sql = "INSERT INTO person(\"clientID\", \"firstName\", \"lastName\", \"phoneNum\", pwd, email)" +
                " VALUES(1 + (SELECT MAX(\"clientID\") FROM person), @firstName, @lastName, @phoneNum, @pwd," +
                " @email)";
            var cmd = new NpgsqlCommand(sql, con);
            cmd.Parameters.AddWithValue("firstName", firstName);
            cmd.Parameters.AddWithValue("lastName", lastName);
            cmd.Parameters.AddWithValue("phoneNum", phoneNumber);
            cmd.Parameters.AddWithValue("pwd", password);
            cmd.Parameters.AddWithValue("email", email);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Redirect("Login_Register.aspx");
        }
    }
}