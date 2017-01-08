using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ComparisonOne.ViewComponents
{
    public class HelloWorld : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
