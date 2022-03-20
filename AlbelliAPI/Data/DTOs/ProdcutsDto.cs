using System.Text.Json.Serialization;

namespace AlbelliAPI.DTOs
{
    public class ProdcutsDto
    {
        public int ProductTypeId { get; set; }

        public string ProductType { get; set; } = string.Empty;
        public int Quantity { get; set; }
    }
}
