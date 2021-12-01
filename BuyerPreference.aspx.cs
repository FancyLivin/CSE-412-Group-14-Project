using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Npgsql;

namespace project
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

            if (maxPriceTextBox.Text == "")
            {
                Session["MaxPrice"] = "999999999";
            }
            if(minPriceTextBox.Text == "")
            {
                Session["MinPrice"] = "0";
            }

            if (DropDownList1.Items[0].Selected)
            {
                Session["ranch"] = "ranch";
            }
            if (DropDownList1.Items[1].Selected)
            {
                Session["mcmansion"] = "mcmansion";
            }
            if (DropDownList1.Items[2].Selected)
            {
                Session["contemporary"] = "contemporary";
            }
            if (DropDownList1.Items[3].Selected)
            {
                Session["craftsman"] = "craftsman";
            }
            if (DropDownList1.Items[4].Selected)
            {
                Session["colonial"] = "colonial";
            }
            if (DropDownList1.Items[5].Selected)
            {
                Session["farmhouse"] = "farmhouse";
            }
            if (DropDownList1.Items[6].Selected)
            {
                Session["ranch"] = "ranch";
                Session["mcmansion"] = "mcmansion";
                Session["contemporary"] = "contemporary";
                Session["craftsman"] = "craftsman";
                Session["colonial"] = "colonial";
                Session["farmhouse"] = "farmhouse";
            }



            Response.Redirect("BuyableHouse.aspx");
        }
    }
}