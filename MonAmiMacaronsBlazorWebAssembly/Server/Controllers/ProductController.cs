using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MonAmiMacaronsBlazorWebAssembly.Server.Services.Products;

namespace MonAmiMacaronsBlazorWebAssembly.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("admin"),Authorize(Roles = "Admin")]
        public async Task<ActionResult<ServiceResponse<List<Product>>>> GetAdminProducts()
        {
            return Ok(await _productService.GetAdminProducts());
        }

        [HttpPost, Authorize(Roles = "Admin")]
        public async Task<ActionResult<ServiceResponse<Product>>> CreateProduct(Product product)
        {
            var result = await _productService.CreateProduct(product);
            return Ok(result);
        }

        [HttpPut, Authorize(Roles = "Admin")]
        public async Task<ActionResult<ServiceResponse<Product>>> UpdateProduct(Product product)
        {
            var result = await _productService.UpdateProduct(product);
            return Ok(result);
        }

        [HttpDelete("{id}"), Authorize(Roles = "Admin")]
        public async Task<ActionResult<ServiceResponse<bool>>> DeleteProduct(int id)
        {
            var result = await _productService.DeleteProduct(id);
            return Ok(result);
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Product>>>> Get()
        {
            return Ok( await _productService.GetAllProductsAsync());
        }

        [HttpGet("{productId:int}")]
        public async Task<ActionResult<ServiceResponse<Product>>> GetProduct(int productId)
        {
            return Ok(await _productService.GetProductAsync(productId));
        }

        [HttpGet("{categoryUrl}")]
        public async Task<ActionResult<ServiceResponse<Product>>> GetProductsByCategory(string categoryUrl)
        {
            return Ok(await _productService.GetProductsByCategoryAsync(categoryUrl));
        }

        [HttpGet("search/{searchText}/{page}")]
        public async Task<ActionResult<ServiceResponse<ProductSearchResult>>> SearchProduct(string searchText, int page = 1)
        {
            return Ok(await _productService.SearchProducts(searchText, page));
        }

        [HttpGet("searchsuggestions/{searchText}")]
        public async Task<ActionResult<ServiceResponse<Product>>> GetProductSearchSuggestions(string searchText)
        {
            return Ok(await _productService.GetProductSearchSuggestions(searchText));
        }
    }
}
