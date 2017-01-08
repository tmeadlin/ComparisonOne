using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComparisonOne.ViewComponents;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace ComparisonOne.Controllers
{
    public class ViewComponentController : Controller
    {
        // GET: /<controller>/
        public IActionResult QuickAndDirty()
        {
            return View();
        }
    }
}
