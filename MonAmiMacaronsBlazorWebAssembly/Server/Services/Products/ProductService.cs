namespace MonAmiMacaronsBlazorWebAssembly.Server.Services.Products
{
    public class ProductService : IProductService
    {
        private readonly DataContext _context;

        public ProductService(DataContext context)
        {
            _context = context;
        }

        public async Task<ServiceResponse<List<Product>>> GetAllProductsAsync()
        {
            var response = new ServiceResponse<List<Product>>();
            response.Data = await _context.Products
                .Include(x => x.Variants)
                .ToListAsync();

            return response;
        }

        public async Task<ServiceResponse<Product>> GetProductAsync(int productId)
        {
            var response = new ServiceResponse<Product>();
            var product = await _context.Products
                .Include(x => x.Variants)
                .ThenInclude(x => x.ProductType)
                .FirstOrDefaultAsync(x => x.Id == productId);

            if (product == null)
            {
                response.Success = false;
                response.Message = "Sorry, but this product does not exist.";
            }
            else
            {
                response.Data = product;
            }
            return response;
        }

        public async Task<ServiceResponse<List<Product>>> GetProductsByCategoryAsync(string categoryUrl)
        {
            var response = new ServiceResponse<List<Product>>
            {
                Data = await _context.Products
                .Where(x => x.Category.Url.ToLower().Equals(categoryUrl.ToLower()))
                .Include(x => x.Variants)
                .ToListAsync()
            };

            return response;
        }

        public async Task<ServiceResponse<List<string>>> GetProductSearchSuggestions(string searchText)
        {
            var products = await FindProductsBySearch(searchText);

            var result = new List<string>();

            foreach (var product in products)
            {
                if (product.Title.Contains(searchText, StringComparison.OrdinalIgnoreCase))
                {
                    result.Add(product.Title);
                }
                if (product.Description != null)
                {
                    var punctuation = product.Description
                        .Where(char.IsPunctuation)
                        .Distinct()
                        .ToArray();
                    var words = product.Description
                        .Split()
                        .Select(x => x.Trim(punctuation));

                    foreach (var word in words)
                    {
                        if (word.Contains(searchText, StringComparison.OrdinalIgnoreCase)
                            && !result.Contains(searchText))
                        {
                            result.Add(word);
                        }
                    }
                }

            }

            return new ServiceResponse<List<string>>() { Data = result };
        }

        public async Task<ServiceResponse<ProductSearchResult>> SearchProducts(string searchText, int page)
        {
            var pageResult = 2f;
            var pageCount = Math.Ceiling((await FindProductsBySearch(searchText)).Count / pageResult);

            var products = await _context.Products
                            .Where(x => x.Title.ToLower().Contains(searchText.ToLower())
                            ||
                            x.Description.ToLower().Contains(searchText.ToLower()))
                            .Include(x => x.Variants)
                            .Skip((page - 1) * (int)pageResult)
                             .Take((int)pageResult)
                             .ToListAsync();


            var response = new ServiceResponse<ProductSearchResult>()
            {
                Data = new ProductSearchResult
                {
                    Products = products,
                    CurrentPage = page,
                    Pages = (int)pageCount
                }
            };

            return response;
        }

        private async Task<List<Product>> FindProductsBySearch(string searchText)
        {
            return await _context.Products
                            .Where(x => x.Title.ToLower().Contains(searchText.ToLower())
                            ||
                            x.Description.ToLower().Contains(searchText.ToLower()))
                            .Include(x => x.Variants)
                            .ToListAsync();
        }
    }
}
