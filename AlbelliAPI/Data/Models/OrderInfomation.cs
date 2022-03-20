
namespace AlbelliAPI.Models
{
    //[Keyless]
    public class OrderInfomation
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)] // as the nature of the assesment I have set this value to non to save the passing orderId
        [Column("OrderId")]
        public int Id { get; set; }

        //
        public virtual List<Order_Product>? Order_Products { get; set; }
    }
}
