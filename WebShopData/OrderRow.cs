namespace WebShopData
{
    public class OrderRow
    {
        public int ArticleId { get; set; }
        public int Quantity { get; set; }
        public string ArticleSummary { get; set; }
        public decimal Amount { get; set; }

        public OrderRow()
        {
            
        }
        public OrderRow(int articleId, int quantity, string articlesummary, decimal amount)
        {
            ArticleId = articleId;
            Quantity = quantity;
            ArticleSummary = articlesummary;
            Amount = amount;
        }
    }
}

