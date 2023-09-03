using ConnectToSqlApp.Models;
using ConnectToSqlApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ConnectToSqlApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IProductService _productService;
        public List<Product> Products;
        public IndexModel(IProductService productService,ILogger<IndexModel> logger)
        {
            _productService = productService;
            _logger = logger;
        }

        public void OnGet()
        {
            
            Products = _productService.GetProducts();
        }
    }
}