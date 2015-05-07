using System;
using System.Web.UI;
using WebShopData;

namespace Project2MySite.Login
{
    public partial class Login : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LabelLoginInfo.Visible = false;
        }
        protected void ButtonLogin_Click(object sender, EventArgs e)
        {
            if (TextBoxLoginUsername.Text != "" && TextBoxLoginPassword.Text != "")
            {
                var userId = UserData.Authenticate(TextBoxLoginUsername.Text, TextBoxLoginPassword.Text);
                if (userId > -1)
                {
                    Session["Username"] = TextBoxLoginUsername.Text;
                    var order = (Order)Session["order"];
                    order.UserId = userId;
                    Response.Redirect("~/MainPage.aspx");
                }
                else
                {
                    LabelLoginInfo.Visible = true;
                }
            }
            else
            {
                LabelLoginInfo.Visible = true;
            }
        }// DONE
    }
}