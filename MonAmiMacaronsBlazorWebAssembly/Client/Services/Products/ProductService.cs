﻿namespace MonAmiMacaronsBlazorWebAssembly.Client.Services.Products
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _httpClient;

        public ProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public List<Product> Products { get; set; } = new List<Product>();
        public string Message { get; set; } = "Loading products...";

        public event Action ProductsChanged;

        public async Task GetAllProducts(string? categoryUrl = null)
        {

            var result = categoryUrl == null ?
                await _httpClient.GetFromJsonAsync<ServiceResponse<List<Product>>>("api/product") :
                await _httpClient.GetFromJsonAsync<ServiceResponse<List<Product>>>($"api/product/{categoryUrl}");
            if (result != null && result.Data != null)
                Products = result.Data;
        }

        public async Task<ServiceResponse<Product>> GetProduct(int productId)
        {
            var result = await _httpClient
                .GetFromJsonAsync<ServiceResponse<Product>>($"api/product/{productId}");

            return result;
        }

        public async Task<List<string>> GetProductsSearchSuggestions(string searchText)
        {
            var result = await _httpClient
                .GetFromJsonAsync<ServiceResponse<List<string>>>($"api/product/searchsuggestions/{searchText}");

            return result.Data;
        }

        public async Task SearchProducts(string searchText)
        {
            var result = await _httpClient
                .GetFromJsonAsync<ServiceResponse<List<Product>>>($"api/product/search/{searchText}");
            if (result != null && result.Data != null)
            {
                Products = result.Data;
            }
            if (Products.Count == 0)
            {
                Message = "No products found.";
            }

            ProductsChanged?.Invoke();
        }
    }
}
