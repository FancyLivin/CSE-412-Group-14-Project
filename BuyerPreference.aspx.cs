using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Npgsql;

namespace CSE412_Group_Project_WebApp
{
    
    public partial class BuyerPreference : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
         
        }

        protected void submitButton2_Click(object sender, EventArgs e)
        {
          
            Session["MaxPrice"] = maxPriceTextBox.Text;
            Session["MinPrice"] = minPriceTextBox.Text;
            Session["BedPref"] = bedPrefTextBox.Text;
            Session["BathPref"] = bathPrefTextBox.Text;
            Session["locPref"] = locPrefTextBox.Text;

            Session["ranch"] = "";
            Session["contemporary"] = "";
            Session["mcmansion"] = "";
            Session["craftsman"] = "";
            Session["colonial"] = "";
            Session["farmhouse"] = "";

            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=TEAM14;User Id=postgres;Password=password");
            conn.Open();

            if (maxPriceTextBox.Text == "")
            {
                maxPriceTextBox.Text = "-1";
                Session["MaxPrice"] = "999999999";
            }
            else
            {
                Session["MaxPrice"] = maxPriceTextBox.Text;
            }

            if (minPriceTextBox.Text == "")
            {
                minPriceTextBox.Text = "-1";
                Session["MinPrice"] = "0";
            }
            else
            {
                Session["MinPrice"] = minPriceTextBox.Text;
            }

            if (bedPrefTextBox.Text == "")
            {
                bedPrefTextBox.Text = "-1";
                Session["BedPref"] = "";
            }
            else
            {
                Session["BedPref"] = bedPrefTextBox.Text;
            }

            if (bathPrefTextBox.Text == "")
            {
                bathPrefTextBox.Text = "-1";
                Session["BathPref"] = "";
            }
            else
            {
                Session["BathPref"] = bathPrefTextBox.Text;
            }

            if (locPrefTextBox.Text == "")
            {
                locPrefTextBox.Text = "";
                Session["locPref"] = "";
            }
            else
            {
                Session["locPref"] = locPrefTextBox.Text;
            }


            var sql = "UPDATE buyer " + "SET " +
                    "\"maxPrice\" = @maxPrice," +
                    "\"minPrice\" = @minPrice," +
                    "\"bedPref\" = @bedPref," +
                    "\"bathPref\" = @bathPref," +
                    "\"locPref\" = @locPref," +
                    "\"stylePref\" = @stylePref" +
                    " WHERE \"clientID\"=" + int.Parse(Session["clientID"].ToString());
            var cmd = new NpgsqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("maxPrice", int.Parse(maxPriceTextBox.Text));
            cmd.Parameters.AddWithValue("minPrice", int.Parse(minPriceTextBox.Text));
            cmd.Parameters.AddWithValue("bedPref", int.Parse(bedPrefTextBox.Text));
            cmd.Parameters.AddWithValue("bathPref", int.Parse(bathPrefTextBox.Text));
            cmd.Parameters.AddWithValue("locPref", locPrefTextBox.Text);




            Label3.Visible = false;
            if (DropDownList1.Items[0].Selected)
            {
                Session["ranch"] = "ranch";
                Label3.Text = "0";
            }
            if (DropDownList1.Items[1].Selected)
            {
                Session["mcmansion"] = "mcmansion";
                Label3.Text = "1";
            }
            if (DropDownList1.Items[2].Selected)
            {
                Session["contemporary"] = "contemporary";
                Label3.Text = "2";

            }
            if (DropDownList1.Items[3].Selected)
            {
                Session["craftsman"] = "craftsman";
                Label3.Text = "3";

            }
            if (DropDownList1.Items[4].Selected)
            {
                Session["colonial"] = "colonial";
                Label3.Text = "4";
            }
            if (DropDownList1.Items[5].Selected)
            {
                Session["farmhouse"] = "farmhouse";
                Label3.Text = "5";
            }
            if (DropDownList1.Items[6].Selected)
            {
                Session["ranch"] = "ranch";
                Session["mcmansion"] = "mcmansion";
                Session["contemporary"] = "contemporary";
                Session["craftsman"] = "craftsman";
                Session["colonial"] = "colonial";
                Session["farmhouse"] = "farmhouse";
                Label3.Text = "6";
            }

            cmd.Parameters.AddWithValue("stylePref", Label3.Text);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            conn.Close();

            Response.Redirect("BuyableHouse.aspx");


            Response.Redirect("BuyableHouse.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=TEAM14;User Id=postgres;Password=password");
            conn.Open();

            var sql = "SELECT \"maxPrice\" FROM buyer WHERE \"clientID\"=" + int.Parse(Session["clientID"].ToString());
            var cmd = new NpgsqlCommand(sql, conn);
            int max = int.Parse(cmd.ExecuteScalar().ToString());
            if (max == -100)
            {
                Label2.Text = "You don't have any old preference!";
            }

            else
            {
                Label2.Text = "";
                //   Label2.Text = loc;
                if (max == -1)
                {
                    maxPriceTextBox.Text = "";
                }
                else
                {
                    maxPriceTextBox.Text = max.ToString();
                }


                sql = "SELECT \"minPrice\" FROM buyer WHERE \"clientID\"=" + int.Parse(Session["clientID"].ToString());
                cmd = new NpgsqlCommand(sql, conn);
                int min = int.Parse(cmd.ExecuteScalar().ToString());
                if (min == -1)
                {
                    minPriceTextBox.Text = "";
                }
                else
                {
                    minPriceTextBox.Text = min.ToString();
                }

                sql = "SELECT \"bedPref\" FROM buyer WHERE \"clientID\"=" + int.Parse(Session["clientID"].ToString());
                cmd = new NpgsqlCommand(sql, conn);
                int beds = int.Parse(cmd.ExecuteScalar().ToString());
                if (beds == -1)
                {
                    bedPrefTextBox.Text = "";
                }
                else
                {
                    bedPrefTextBox.Text = beds.ToString();
                }


                sql = "SELECT \"bathPref\" FROM buyer WHERE \"clientID\"=" + int.Parse(Session["clientID"].ToString());
                cmd = new NpgsqlCommand(sql, conn);
                int baths = int.Parse(cmd.ExecuteScalar().ToString());
                if (baths == -1)
                {
                    bathPrefTextBox.Text = "";
                }
                else
                {
                    bathPrefTextBox.Text = baths.ToString();
                }

                sql = "SELECT \"locPref\" FROM buyer WHERE \"clientID\"=" + int.Parse(Session["clientID"].ToString());
                cmd = new NpgsqlCommand(sql, conn);
                string loc = cmd.ExecuteScalar().ToString().TrimStart().TrimEnd();
                locPrefTextBox.Text = loc;

                sql = "SELECT \"stylePref\" FROM buyer WHERE \"clientID\"=" + int.Parse(Session["clientID"].ToString());
                cmd = new NpgsqlCommand(sql, conn);
                string stylePref = cmd.ExecuteScalar().ToString();
                if (int.Parse(stylePref) == 0)
                {
                    DropDownList1.Items.FindByValue("--select--").Selected = false;
                    DropDownList1.Items.FindByValue("mcmansion").Selected = false;
                    DropDownList1.Items.FindByValue("colonial").Selected = false;
                    DropDownList1.Items.FindByValue("contemporary").Selected = false;
                    DropDownList1.Items.FindByValue("farmhouse").Selected = false;
                    DropDownList1.Items.FindByValue("craftsman").Selected = false;
                    DropDownList1.Items.FindByValue("ranch").Selected = true;
                }
                if (int.Parse(stylePref) == 1)
                {
                    DropDownList1.Items.FindByValue("--select--").Selected = false;
                    DropDownList1.Items.FindByValue("mcmansion").Selected = true;
                    DropDownList1.Items.FindByValue("colonial").Selected = false;
                    DropDownList1.Items.FindByValue("contemporary").Selected = false;
                    DropDownList1.Items.FindByValue("farmhouse").Selected = false;
                    DropDownList1.Items.FindByValue("craftsman").Selected = false;
                    DropDownList1.Items.FindByValue("ranch").Selected = false;
                }
                if (int.Parse(stylePref) == 2)
                {
                    DropDownList1.Items.FindByValue("--select--").Selected = false;
                    DropDownList1.Items.FindByValue("mcmansion").Selected = false;
                    DropDownList1.Items.FindByValue("colonial").Selected = false;
                    DropDownList1.Items.FindByValue("contemporary").Selected = true;
                    DropDownList1.Items.FindByValue("farmhouse").Selected = false;
                    DropDownList1.Items.FindByValue("craftsman").Selected = false;
                    DropDownList1.Items.FindByValue("ranch").Selected = false;
                }
                if (int.Parse(stylePref) == 3)
                {
                    DropDownList1.Items.FindByValue("--select--").Selected = false;
                    DropDownList1.Items.FindByValue("mcmansion").Selected = false;
                    DropDownList1.Items.FindByValue("colonial").Selected = false;
                    DropDownList1.Items.FindByValue("contemporary").Selected = false;
                    DropDownList1.Items.FindByValue("farmhouse").Selected = false;
                    DropDownList1.Items.FindByValue("craftsman").Selected = true;
                    DropDownList1.Items.FindByValue("ranch").Selected = false;
                }
                if (int.Parse(stylePref) == 4)
                {
                    DropDownList1.Items.FindByValue("--select--").Selected = false;
                    DropDownList1.Items.FindByValue("mcmansion").Selected = false;
                    DropDownList1.Items.FindByValue("colonial").Selected = true;
                    DropDownList1.Items.FindByValue("contemporary").Selected = false;
                    DropDownList1.Items.FindByValue("farmhouse").Selected = false;
                    DropDownList1.Items.FindByValue("craftsman").Selected = false;
                    DropDownList1.Items.FindByValue("ranch").Selected = false;
                }
                if (int.Parse(stylePref) == 5)
                {
                    DropDownList1.Items.FindByValue("--select--").Selected = false;
                    DropDownList1.Items.FindByValue("mcmansion").Selected = false;
                    DropDownList1.Items.FindByValue("colonial").Selected = false;
                    DropDownList1.Items.FindByValue("contemporary").Selected = false;
                    DropDownList1.Items.FindByValue("farmhouse").Selected = true;
                    DropDownList1.Items.FindByValue("craftsman").Selected = false;
                    DropDownList1.Items.FindByValue("ranch").Selected = false;
                }
                if (int.Parse(stylePref) == 6)
                {
                    DropDownList1.Items.FindByValue("--select--").Selected = true;
                    DropDownList1.Items.FindByValue("mcmansion").Selected = false;
                    DropDownList1.Items.FindByValue("colonial").Selected = false;
                    DropDownList1.Items.FindByValue("contemporary").Selected = false;
                    DropDownList1.Items.FindByValue("farmhouse").Selected = false;
                    DropDownList1.Items.FindByValue("craftsman").Selected = false;
                    DropDownList1.Items.FindByValue("ranch").Selected = false;
                }

                cmd.Dispose();
                conn.Close();
            }
        }
    }
}