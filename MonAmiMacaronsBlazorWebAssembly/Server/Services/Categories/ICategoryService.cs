namespace MonAmiMacaronsBlazorWebAssembly.Server.Services.Categories
{
    public interface ICategoryService
    {
        Task<ServiceResponse<List<Category>>> GetCategories();
    }
}
