namespace BlazorServerAppTest1.Data
{
    public class Orders
    {
        public int orderId { get; set; }
        public string customerName { get; set; }
        public DateTime orderDate { get; set; }
        public List<OrderDetails> details { get; set; }
    }

    public class OrderDetails
    {
        public int orderId { get; set; }
        public int productId { get; set; }
        public string productName { get; set; }
        public decimal Qty { get; set; }
        public decimal price { get; set; }
    }
}
