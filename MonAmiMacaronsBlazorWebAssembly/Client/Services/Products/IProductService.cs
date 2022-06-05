namespace MonAmiMacaronsBlazorWebAssembly.Client.Services.Products
{
    public interface IProductService
    {
        List<Product> Products { get; set; }
        Task GetAllProducts();
    }
}
