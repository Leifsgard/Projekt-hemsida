using WebShopData.ProjectWebStoreDataSetTableAdapters;

namespace WebShopData
{
    public class WebShopDAL
    {
        OrderHeadTableAdapter orderHead = new OrderHeadTableAdapter();  
        public void AddOrderToDB(Order order)
        {
            orderHead.Insert(order.UserId, order.Address, order.Zip, order.City,true);
        }
    }
}
