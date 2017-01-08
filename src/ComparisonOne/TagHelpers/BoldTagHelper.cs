using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace ComparisonOne.TagHelpers
{
    [HtmlTargetElement("div", Attributes = "strong")]
    public class BoldTagHelper : TagHelper
    {
        public override int Order => 2;

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.PreContent.SetHtmlContent("<strong>");
            output.PostContent.SetHtmlContent("</strong>");
        }
    }
}
