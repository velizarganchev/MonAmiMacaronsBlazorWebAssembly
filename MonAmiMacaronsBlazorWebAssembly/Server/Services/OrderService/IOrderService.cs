﻿namespace MonAmiMacaronsBlazorWebAssembly.Server.Services.OrderService
{
    public interface IOrderService
    {
        public int Shipping { get; set; }
        Task<ServiceResponse<bool>> PlaceOrder(int userId);
        Task<ServiceResponse<List<OrderOverviewResponse>>> GetOrders();
        Task<ServiceResponse<OrderDetailsResponse>> GetOrderDetails(int orderId);
    }
}
