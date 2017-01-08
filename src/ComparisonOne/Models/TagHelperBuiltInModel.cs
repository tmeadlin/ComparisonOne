using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ComparisonOne.Models
{
    public class TagHelperBuiltInModel
    {
        [Display(Name = "Widget Name")]
        public string WidgetName { get; set; }

        [Display(Name="Widget Type")]
        public string WidgetType { get; set; }

        public IList<SelectListItem> WidgetTypes { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "end", Text = "Goodbye!" },
            new SelectListItem { Value = "start", Text = "Hello World" },
            new SelectListItem { Value = "middle", Text = "Stuck in the middle" }            
        };
    }
}
