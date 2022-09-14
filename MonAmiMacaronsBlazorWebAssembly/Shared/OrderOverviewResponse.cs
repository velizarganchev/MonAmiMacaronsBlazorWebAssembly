namespace MonAmiMacaronsBlazorWebAssembly.Shared
{
    public class OrderOverviewResponse
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalPrice { get; set; }
        public string Product { get; set; } = string.Empty;
        public string ProductImage { get; set; } = string.Empty;
    }
}
