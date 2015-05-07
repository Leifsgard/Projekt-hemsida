using System;
using System.Web;
using System.Web.UI.WebControls;
using WebShopData;

namespace Project2MySite
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidateLogin();
            if (((Order)Session["order"]).UserId < 0)
            {
                Server.Transfer("Login/Login.aspx");
            }
            AddToCart();
        }// DONE
        private void ValidateLogin()
        {
            if (!IsPostBack)
            {
                if (Session["Username"] != null)
                {
                    if (!string.IsNullOrEmpty((string)Session["Username"]))
                    {
                        LabelLoggedOn.Text = "Welcome " + Session["Username"];
                    }
                    else
                    {
                        Server.Transfer("Login/Login.aspx");
                    }
                }
                else
                {
                    Server.Transfer("Login/Login.aspx");
                }
            }
        } //DONE
        private void AddToCart()
        {
            try
            {
                if (DropDownListCart.Items.Count == 0 && ((Order)Session["order"]).OrderRows != null)
                {
                    foreach (var newItem in ((Order)Session["order"]).OrderRows)
                    {
                        var productValue = string.Format(newItem.Quantity + " | " + newItem.ArticleId);
                        var productViewText = string.Format(newItem.Quantity + newItem.ArticleSummary);
                        var item = new ListItem(productViewText, productValue);

                        DropDownListCart.Items.Add(item);
                    }
                }
            }
            catch (HttpException)
            {
                Server.Transfer("Error/ErrorPage.aspx");
            }
        }// DONE
        protected void ButtonLogout_Click(object sender, EventArgs e)
        {
            Session["Username"] = null;
            Session["order"] = new Order();
            Server.Transfer("Login/Login.aspx");
        }// DONE
        protected void DropDownListCart_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["order"] = DropDownListCart.SelectedValue;
        } //DONE
    }
}