using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace ComparisonOne.TagHelpers
{
    [HtmlTargetElement("div", Attributes = "my-paragraph")]    
    public class MyParagraphTagHelper : TagHelper
    {
        [HtmlAttributeName("is-bold")]
        public bool IsBold { get; set; }

        public bool Show { get; set; }

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            if (!Show)
            {
                output.SuppressOutput();
                return;
            }

            var childContent = await output.GetChildContentAsync();
            var content = childContent.GetContent();

            if (IsBold)
                output.Content.SetHtmlContent($"<strong>{content}</strong>");
        }
    }
}
