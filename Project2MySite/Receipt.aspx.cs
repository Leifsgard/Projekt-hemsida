using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project2MySite
{
    public partial class Receipt : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HyperLink checkout = null;
            if (Master != null)
            {
                checkout = (HyperLink)Master.FindControl("HyperLinkOrderConfirmation");
            }
            if (checkout != null) checkout.Visible = false;
        }
    }
}