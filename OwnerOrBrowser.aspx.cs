using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CSE412_Group_Project_WebApp
{
    public partial class OwnerOrBrowser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ownerButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("OwnerMenu.aspx");
        }

        protected void browserButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("BuyerOrRenter.aspx");
        }
    }
}