namespace MonAmiMacaronsBlazorWebAssembly.Shared
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.UtcNow;
        public decimal TotalPrice { get; set; }
        public List<OrderItem> Orders { get; set; } = new List<OrderItem>();
    }
}
