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
            response.Data = await _context.Products.ToListAsync();

            return response;
        }
    }
}
