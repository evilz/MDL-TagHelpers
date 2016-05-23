using MaterialDesignLite.WebSample.ViewModels;
using Microsoft.AspNetCore.Mvc;
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

        public IActionResult GettingStarted()
        {
            return View(new PageViewConfig
            {
                Header = new Header
                {
                    BgColor = MDLColors.Cyan,
                    Title = "Getting Started",
                    SubTitle = "...."
                },
            });
        }




    }
}
