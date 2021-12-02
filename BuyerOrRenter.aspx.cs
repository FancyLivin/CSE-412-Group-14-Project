using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CSE412_Group_Project_WebApp
{
    public partial class BuyerOrRenter : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void buyerButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("BuyerPreference.aspx");
        }

        protected void renterButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("RenterPreference.aspx");
        }
    }
}