namespace AlbelliAPI.DTOs
{
    public class OrderInfoSaveDto
    {
        public int OrderId { get; set; }
        public List<ProdcutsDto>? ProdcutsDtos{ get; set; }
    }
}
