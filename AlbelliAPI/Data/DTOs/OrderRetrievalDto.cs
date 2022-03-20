namespace AlbelliAPI.DTOs
{
    public class OrderRetrievalDto
    {
        public int OrderId { get; set; }
        public List<ProdcutsDto>?  ProdcutsDtos { get; set; }
        public string RequiredBinWidth { get; set; } = String.Empty;
    }
}
