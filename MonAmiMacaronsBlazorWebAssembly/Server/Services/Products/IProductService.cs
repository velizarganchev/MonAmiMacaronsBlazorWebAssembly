namespace MonAmiMacaronsBlazorWebAssembly.Server.Services.Products
{
    public interface IProductService
    {
        Task<ServiceResponse<List<Product>>> GetAllProductsAsync();
    }
}
