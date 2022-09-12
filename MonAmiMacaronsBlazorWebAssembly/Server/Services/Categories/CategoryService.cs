﻿namespace MonAmiMacaronsBlazorWebAssembly.Server.Services.Categories
{
    public class CategoryService : ICategoryService
    {
        private readonly DataContext _context;

        public CategoryService(DataContext context)
        {
            _context = context;
        }

        public async Task<ServiceResponse<List<Category>>> AddCategory(Category category)
        {
            category.Editing = category.IsNew = false;
            _context.Categories.Add(category);
            await _context.SaveChangesAsync();

            return await GetAdminCategories();
        }

        public async Task<ServiceResponse<List<Category>>> DeleteCategoy(int id)
        {
            var category = await GetCategoryById(id);

            if (category == null)
            {
                return new ServiceResponse<List<Category>>
                {
                    Success = false,
                    Message = "Category not found."
                };
            }

            category.Deleted = true;
            await _context.SaveChangesAsync();

            return await GetAdminCategories();

        }

        private async Task<Category> GetCategoryById(int id)
        {
            return await _context.Categories.FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<ServiceResponse<List<Category>>> GetAdminCategories()
        {
            var response = new ServiceResponse<List<Category>>()
            {
                Data = await _context.Categories.Where(c => !c.Deleted).ToListAsync()
            };

            return response;
        }

        public async Task<ServiceResponse<List<Category>>> GetCategories()
        {
            var response = new ServiceResponse<List<Category>>()
            {
                Data = await _context.Categories.Where(c => !c.Deleted && c.Visible).ToListAsync()
            };

            return response;
        }

        public async Task<ServiceResponse<List<Category>>> UpdateCategory(Category category)
        {
            var dbCategory = await GetCategoryById(category.Id);

            if (category == null)
            {
                return new ServiceResponse<List<Category>>
                {
                    Success = false,
                    Message = "Category not found."
                };
            }

            dbCategory.Name = category.Name;
            dbCategory.Url = category.Url;
            dbCategory.Visible = category.Visible;

            await _context.SaveChangesAsync();

            return await GetAdminCategories();
        }
    }
}
