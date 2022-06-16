namespace MonAmiMacaronsBlazorWebAssembly.Client.Services.Categories
{
    public interface ICategoryService
    {
        List<Category> Categories { get; set; }
        Task GetAllCategories();
    }
}
