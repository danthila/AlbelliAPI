namespace AlbelliAPI.Models
{
    public class Order_Product
    {
        public int Id { get; set; }

        public int OrderId { get; set; }
        public OrderInfomation? OrderInfomation { get; set; }

        public int ProductId { get; set; }
        public ProdcutType? ProdcutType { get; set; }

        public int Quantity { get; set; }
    }
}
