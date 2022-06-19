﻿namespace MonAmiMacaronsBlazorWebAssembly.Client.Services.Products
{
    public interface IProductService
    {
        List<Product> Products { get; set; }
        Product Product { get; set; }
        Task GetAllProducts(string? categoryUrl = null);
        Task<ServiceResponse<Product>> GetProduct(int productId);
    }
}
