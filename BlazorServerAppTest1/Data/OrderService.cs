namespace BlazorServerAppTest1.Data
{
    public class OrderService
    {
        List<Orders> orders = new List<Orders>()
        {
            new Orders(){
                orderId = 1, customerName = "Ahmed", orderDate = Convert.ToDateTime("2023-1-22"),
                details = new List<OrderDetails>
                {
                    new OrderDetails() { orderId = 1, productId=101, productName ="pen", Qty = 3 , price = 10 },
                    new OrderDetails() { orderId = 1, productId=102, productName ="book", Qty = 2 , price = 150 },
                    new OrderDetails() { orderId = 1, productId=103, productName ="flash", Qty = 1 , price = 280 },
                }
            },
            new Orders(){
                orderId = 2, customerName = "Mohamed", orderDate = Convert.ToDateTime("2023-5-2"),
                details = new List<OrderDetails>
                {
                    new OrderDetails() { orderId = 2, productId=104, productName ="car", Qty = 1 , price = 500 },
                    new OrderDetails() { orderId = 2, productId=103, productName ="flash", Qty = 3 , price = 520 },
                }
            },
            new Orders(){
                orderId = 3, customerName = "Salah", orderDate = Convert.ToDateTime("2023-6-8"),
                details = new List<OrderDetails>
                {
                    new OrderDetails() { orderId = 3, productId=101, productName ="desk", Qty = 1 , price = 852 },
                    new OrderDetails() { orderId = 3, productId=102, productName ="chair", Qty = 2 , price = 350 },
                    new OrderDetails() { orderId = 3, productId=103, productName ="box", Qty = 5 , price = 500 },
                }
            },
        };

        public async Task<List<Orders>> OrderList()
        { 
           return await Task.FromResult(orders);
        }
    }
}
