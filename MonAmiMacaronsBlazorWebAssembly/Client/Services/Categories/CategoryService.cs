﻿using static System.Net.WebRequestMethods;

namespace MonAmiMacaronsBlazorWebAssembly.Client.Services.Categories
{
    public class CategoryService : ICategoryService
    {
        private readonly HttpClient _httpClient;

        public CategoryService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public List<Category> Categories { get; set; } = new List<Category>();
        public List<Category> AdminCategories { get; set; } = new List<Category>();

        public event Action OnChange;

        public async Task AddCategory(Category category)
        {
            var response = await _httpClient.PostAsJsonAsync("api/category/admin", category);
            AdminCategories = (await response.Content
                .ReadFromJsonAsync<ServiceResponse<List<Category>>>()).Data;

            await GetAllCategories();

            OnChange.Invoke();
        }

        public Category CreateNewCategory()
        {
            var newCategory = new Category { IsNew = true, Editing = true };
            AdminCategories.Add(newCategory);

            OnChange.Invoke();

            return newCategory;
        }

        public async Task DeleteCategory(int categoryId)
        {
            var response = await _httpClient.DeleteAsync($"api/category/admin/{categoryId}");
            AdminCategories = (await response.Content
                .ReadFromJsonAsync<ServiceResponse<List<Category>>>()).Data;

            await GetAllCategories();

            OnChange.Invoke();
        }

        public async Task GetAdminCategories()
        {
            var response = await _httpClient.GetFromJsonAsync<ServiceResponse<List<Category>>>("api/category/admin");
            if (response != null && response.Data != null)
                AdminCategories = response.Data;
        }

        public async Task GetAllCategories()
        {
            var response = await _httpClient.GetFromJsonAsync<ServiceResponse<List<Category>>>("api/category");
            if (response != null && response.Data != null)
                Categories = response.Data;
        }

        public async Task UpdateCategory(Category category)
        {
            var response = await _httpClient.PutAsJsonAsync("api/category/admin", category);
            AdminCategories = (await response.Content
                .ReadFromJsonAsync<ServiceResponse<List<Category>>>()).Data;

            await GetAllCategories();

            OnChange.Invoke();
        }
    }
}
