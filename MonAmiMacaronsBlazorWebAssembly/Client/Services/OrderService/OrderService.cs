using Microsoft.AspNetCore.Components;

namespace MonAmiMacaronsBlazorWebAssembly.Client.Services.OrderService
{
    public class OrderService : IOrderService
    {
        private readonly HttpClient _httpClient;
        private readonly IAuthService _authService;
        private readonly NavigationManager _navigationManager;

        public OrderService(HttpClient httpClient,
            IAuthService authService,
            NavigationManager navigationManager)
        {
            _httpClient = httpClient;
            _authService = authService;
            _navigationManager = navigationManager;
        }

        public async Task<List<OrderOverviewResponse>> GetOrder()
        {
            var result = await _httpClient.GetFromJsonAsync<ServiceResponse<List<OrderOverviewResponse>>>("api/order");

            return result.Data;
        }

        public async Task<OrderDetailsResponse> GetOrderDetails(int orderId)
        {
            var result = await _httpClient.GetFromJsonAsync<ServiceResponse<OrderDetailsResponse>>($"api/order/{orderId}");

            return result.Data;
        }

        public async Task PlaceOrder()
        {
            if (await _authService.IsUserAuthenticated())
            {
                await _httpClient.PostAsync("api/order", null);
            }
            else
            {
                _navigationManager.NavigateTo("login");
            }
        }
    }
}
