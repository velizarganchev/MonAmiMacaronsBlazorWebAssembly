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

        public async Task<ServiceResponse<List<Product>>> SearchProducts(string searchText)
        {
            var response = new ServiceResponse<List<Product>>()
            {
                Data = await _context.Products
                .Where(x => x.Title.ToLower().Contains(searchText.ToLower())
                ||
                x.Description.ToLower().Contains(searchText.ToLower()))
                .Include(x => x.Variants)
                .ToListAsync()
            };

            return response;
        }
    }
}
