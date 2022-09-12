namespace MonAmiMacaronsBlazorWebAssembly.Client.Services.OrderService
{
    public interface IOrderService
    {
        Task<string> Checkout();
        Task<List<OrderOverviewResponse>> GetOrder();
        Task<OrderDetailsResponse> GetOrderDetails(int orderId);
    }
}
