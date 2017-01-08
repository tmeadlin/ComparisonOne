using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComparisonOne.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace ComparisonOne.Controllers
{
    public class TagHelperController : Controller
    {
        // GET: /<controller>/
        public IActionResult BuiltIn()
        {
            return View(new TagHelperBuiltInModel { WidgetName = "Silly Dilly", WidgetType = "start"});
        }

        public IActionResult Custom()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SubmitForm(TagHelperBuiltInModel model)
        {
            throw new NotImplementedException();
        }
    }
}
