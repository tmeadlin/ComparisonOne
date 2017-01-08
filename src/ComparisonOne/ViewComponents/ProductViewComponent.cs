using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComparisonOne.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ComparisonOne.ViewComponents
{
    public class ProductViewComponent : ViewComponent
    {
        private readonly IProductService _productService;

        public ProductViewComponent(IProductService productService)
        {
            _productService = productService;
        }

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
