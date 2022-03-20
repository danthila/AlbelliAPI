namespace AlbelliAPI.Models
{

    public class ProdcutType
    {
        [Column("ProdcutId")]
        public int Id { get; set; }
        public string ProdcutName { get; set; } = string.Empty;

        public virtual List<Order_Product>? Order_Products { get; set; }
    }
}
