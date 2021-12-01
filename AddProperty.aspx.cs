using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Npgsql;

namespace CSE412_Group_Project_WebApp
{
    public partial class AddProperty : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SaleButton_Click(object sender, EventArgs e)
        {
            string address = addressTextBox.Text;
            string city = cityTextBox.Text;
            string country = countryTextBox.Text;
            string yearBuilt = yearTextBox.Text;
            int sqft = Convert.ToInt32(sqftTextBox.Text);
            int beds = Convert.ToInt32(bedsTextBox.Text);
            int baths = Convert.ToInt32(bathsTextBox.Text);
            string houseStyle = "N/A";
            if (DropDownList1.Items[0].Selected)
            {
                houseStyle = "ranch";
            }
            if (DropDownList1.Items[1].Selected)
            {
                houseStyle = "mcmansion";
            }
            if (DropDownList1.Items[2].Selected)
            {
                houseStyle = "contemporary";
            }
            if (DropDownList1.Items[3].Selected)
            {
                houseStyle = "craftsman";
            }
            if (DropDownList1.Items[4].Selected)
            {
                houseStyle = "colonial";
            }
            if (DropDownList1.Items[5].Selected)
            {
                houseStyle = "farmhouse";
            }
            int clientID = Convert.ToInt32(Session["clientID"]);
            NpgsqlConnection con = new NpgsqlConnection("Host=localhost;Username=postgres;Password=password;Database=TEAM14");
            con.Open();
            var sql = "SELECT MAX(\"propID\") FROM house";
            var cmd = new NpgsqlCommand(sql, con);
            NpgsqlDataReader rdr = cmd.ExecuteReader();
            var propID = 0;
            if (rdr.Read())
            {
                propID = rdr.GetInt32(0) + 1;
            }
            sql = "INSERT INTO house(\"propID\", address, city, country, \"yearBuilt\"," +
                "sqft, beds, baths, \"houseStyle\", \"ownerID\") VALUES(" +
                "@pid, @address, @city, @country, @yearBuilt, @sqft, @beds, @baths, @houseStyle, @id)";
            cmd = new NpgsqlCommand(sql, con);
            cmd.Parameters.AddWithValue("address", address);
            cmd.Parameters.AddWithValue("city", city);
            cmd.Parameters.AddWithValue("country", country);
            cmd.Parameters.AddWithValue("yearBuilt", yearBuilt);
            cmd.Parameters.AddWithValue("sqft", sqft);
            cmd.Parameters.AddWithValue("beds", beds);
            cmd.Parameters.AddWithValue("baths", baths);
            cmd.Parameters.AddWithValue("houseStyle", houseStyle);
            cmd.Parameters.AddWithValue("id", clientID);
            cmd.Parameters.AddWithValue("pid", propID);
            cmd.Prepare();
            cmd.ExecuteNonQuery();

            int price = Convert.ToInt32(priceTextBox.Text);
            sql = "Insert INTO buyable \"propID\", \"price\") VALUES(@propID, @price)";
            cmd = new NpgsqlCommand(sql, con);
            cmd.Parameters.AddWithValue("propID", propID);
            cmd.Parameters.AddWithValue("price", price);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            con.Close();

            Label2.Text = "You have successfully listed your house to sell!";
        }

        protected void RentButton_Click(object sender, EventArgs e)
        {
            string address = addressTextBox.Text;
            string city = cityTextBox.Text;
            string country = countryTextBox.Text;
            string yearBuilt = yearTextBox.Text;
            int sqft = Convert.ToInt32(sqftTextBox.Text);
            int beds = Convert.ToInt32(bedsTextBox.Text);
            int baths = Convert.ToInt32(bathsTextBox.Text);
            string houseStyle = "N/A";
            if (DropDownList1.Items[0].Selected)
            {
                houseStyle = "ranch";
            }
            if (DropDownList1.Items[1].Selected)
            {
                houseStyle = "mcmansion";
            }
            if (DropDownList1.Items[2].Selected)
            {
                houseStyle = "contemporary";
            }
            if (DropDownList1.Items[3].Selected)
            {
                houseStyle = "craftsman";
            }
            if (DropDownList1.Items[4].Selected)
            {
                houseStyle = "colonial";
            }
            if (DropDownList1.Items[5].Selected)
            {
                houseStyle = "farmhouse";
            }
            int clientID = Convert.ToInt32(Session["clientID"]);
            NpgsqlConnection con = new NpgsqlConnection("Host=localhost;Username=postgres;Password=password;Database=TEAM14");
            con.Open();
            var sql = "SELECT MAX(\"propID\") FROM house";
            var cmd = new NpgsqlCommand(sql, con);
            NpgsqlDataReader rdr = cmd.ExecuteReader();
            var propID = 0;
            if (rdr.Read())
            {
                propID = rdr.GetInt32(0) + 1;
            }
            sql = "INSERT INTO house(\"propID\", address, city, country, \"yearBuilt\"," +
                "sqft, beds, baths, \"houseStyle\", \"ownerID\") VALUES(" +
                "@pid, @address, @city, @country, @yearBuilt, @sqft, @beds, @baths, @houseStyle, @id)";
            cmd = new NpgsqlCommand(sql, con);
            cmd.Parameters.AddWithValue("address", address);
            cmd.Parameters.AddWithValue("city", city);
            cmd.Parameters.AddWithValue("country", country);
            cmd.Parameters.AddWithValue("yearBuilt", yearBuilt);
            cmd.Parameters.AddWithValue("sqft", sqft);
            cmd.Parameters.AddWithValue("beds", beds);
            cmd.Parameters.AddWithValue("baths", baths);
            cmd.Parameters.AddWithValue("houseStyle", houseStyle);
            cmd.Parameters.AddWithValue("id", clientID);
            cmd.Parameters.AddWithValue("pid", propID);
            cmd.Prepare();
            cmd.ExecuteNonQuery();

            int priceMonth = Convert.ToInt32(priceTextBox.Text);
            int yrsToRent = Convert.ToInt32(rentTimeTextBox.Text);
            sql = "INSERT INTO rentable(\"propID\", \"priceMonth\", \"yrsToRent\")" +
                "VALUES(@propID, @priceMonth, @yrsToRent)";
            cmd = new NpgsqlCommand(sql, con);
            cmd.Parameters.AddWithValue("propID", propID);
            cmd.Parameters.AddWithValue("priceMonth", priceMonth);
            cmd.Parameters.AddWithValue("yrsToRent", yrsToRent);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            con.Close();

            Label2.Text = "You have successfully listed your house to rent!";
        }
    }
}