using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebShopData;

namespace Project2MySite
{
    public partial class MainPage : Page
    {
        DropDownList _fromTheGrid;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Master != null)
            {
                _fromTheGrid = (DropDownList)Master.FindControl("DropDownListCart");
            }
        }// DONE
        protected void GridView_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "AddToCart":

                    var order = (Order)Session["order"];
                    var index = int.Parse(e.CommandArgument.ToString());
                    
                    GridViewRow row = GridView.Rows[index];

                    var articleId = int.Parse(row.Cells[0].Text);
                    var articleText = row.Cells[1].Text;
                    var articlePrice = decimal.Parse(row.Cells[2].Text);
                    const int amount = 1;

                    var newItem = new OrderRow(articleId, amount, articleText, articlePrice);

                    var productValue = string.Format(newItem.ArticleId + "," + newItem.Quantity);
                    var productViewText = string.Format(newItem.ArticleSummary + " - " + "Amount: " + amount);
                    var item = new ListItem(productViewText, productValue);
                    
                    _fromTheGrid.Items.Add(item);

                    if (order.OrderRows == null)
                    {
                        order.OrderRows = new List<OrderRow>();
                    }
                    order.OrderRows.Add(newItem);
                    break;
            }
        }// DONE
        protected void GridView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}