﻿namespace MonAmiMacaronsBlazorWebAssembly.Client.Services.Products
{
    public interface IProductService
    {
        event Action ProductsChanged;
        List<Product> Products { get; set; }
        string Message { get; set; }
        public int CurrentPage { get; set; }
        public int PageCount { get; set; }
        public string LastSearchText { get; set; }
        Task GetAllProducts(string? categoryUrl = null);
        Task<ServiceResponse<Product>> GetProduct(int productId);
        Task SearchProducts(string searchText, int page);
        Task<List<string>> GetProductsSearchSuggestions(string searchText);

    }
}
