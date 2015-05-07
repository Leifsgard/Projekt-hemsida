using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using WebShopData;
using WebShopData.ProjectWebStoreDataSetTableAdapters;

namespace Project2MySite
{
    public partial class Checkout : Page
    {
        OrderHeadTableAdapter orders = new OrderHeadTableAdapter();
        OrderRowTableAdapter orderRow = new OrderRowTableAdapter();
        protected void Page_Load(object sender, EventArgs e)
        {
            OrderSummary();
            if (LabelTotalSum.Text.Length > 13)
            {
                ButtonCashier.Visible = true;
            }
        }
        private void OrderSummary()
        {
            try
            {
                ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
                var order = (Order) Session["order"];

                LabelProduct.Text = "";
                var totalCost = 0m;

                if (order.OrderRows != null)
                {
                    foreach (var orderRow in order.OrderRows)
                    {
                        var totalPrice = orderRow.Amount*orderRow.Quantity;
                        totalCost += totalPrice;

                        var textSummary = string.Format("{0}", orderRow.ArticleSummary);
                        var textAmount = string.Format("{0}", orderRow.Amount.ToString("G29"));
                        var textQuantity = string.Format("{0}", orderRow.Quantity);

                        LabelProduct.Text += textSummary + "<br>";
                        LabelPrice.Text += textAmount + "<br>";
                        LabelQuantity.Text += textQuantity + "<br>";
                    }
                    LabelTotalSum.Text += "Total Cost: " + totalCost.ToString("G29");
                    Session["totalCost"] = totalCost.ToString("G29");
                }
            }
            catch (HttpException)
            {
                Server.Transfer("Error/ErrorPage.aspx");
            }
        }// DONE
        protected void ButtonCashier_Click(object sender, EventArgs e)
        {
            try
            {
                var addOrder = new WebShopDAL();
                var order = (Order) Session["order"];
                order.Address = TextBoxAdress.Text;
                order.Zip = TextBoxZip.Text;
                order.City = TextBoxCity.Text;
                addOrder.AddOrderToDB(order);

                foreach (var item in order.OrderRows)
                {
                    orderRow.Insert(orders.GetDataBy(order.UserId).Last().OrderID, item.Quantity, item.ArticleId);
                }

                Session["order"] = new Order(order.UserId);
                Server.Transfer("~/Receipt.aspx");
            }
            catch (HttpException)
            {
                Server.Transfer("Error/ErrorPage.aspx");
            }
        }// DONE
        protected void ButtonClear_Click(object sender, EventArgs e)
        {
            var order = (Order) Session["order"];
            if (order.OrderRows == null) return;
            order.OrderRows = new List<OrderRow>();
            order.OrderRows.Clear();
            Server.Transfer(Request.Path);//nollar och stannar på sidan
        }// DONE
    }
}