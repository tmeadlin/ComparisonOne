using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComparisonOne.Core.Interfaces;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace ComparisonOne.TagHelpers
{
    public class ProductTagHelper : TagHelper
    {
        private readonly IProductService _productService;

        public ProductTagHelper(IProductService productService)
        {
            _productService = productService;
        }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
        }
    }
}
