using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using MaterialDesignLite.WebSample.ViewModels;
using MaterialDesignLite.TagHelpers.StyleValues;

namespace MaterialDesignLite.WebSample.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(new PageViewConfig
            {
                Header = new Header
                {
                    BgColor = MDLColors.Cyan,
                    Title = "Home",
                    SubTitle = "...."
                },
            });
        }

      
    }
}
