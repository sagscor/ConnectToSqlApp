﻿using ConnectToSqlApp.Models;
using ConnectToSqlApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ConnectToSqlApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public List<Product> Products;
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            ProductService productService = new ProductService();
            Products = productService.GetProducts();
        }
    }
}