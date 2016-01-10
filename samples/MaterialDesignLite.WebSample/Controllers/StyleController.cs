using MaterialDesignLite.TagHelpers.StyleValues;
using MaterialDesignLite.WebSample.ViewModels;
using Microsoft.AspNet.Mvc;

namespace MaterialDesignLite.WebSample.Controllers
{
    public class StyleController : Controller
    {
        public IActionResult Icons()
        {
            return View(new PageViewConfig
            {
                Header = new Header
                {
                    BgColor = MDLColors.LightBlue,
                    Title = "Icons",
                    SubTitle = "UI icon, symbolizes a command, file, device, or directory. System icons are also used to represent common actions like trash, print, and save."
                },
            });
        }

        public IActionResult Colors()
        {
            return View(new PageViewConfig
            {
                Header = new Header
                {
                    BgColor = MDLColors.Blue,
                    Title = "Colors",
                    SubTitle = "Color in material design is inspired by bold hues juxtaposed with muted environments, deep shadows, and bright highlights."
                },
            });
        }

        public IActionResult Typography()
        {
            return View(new PageViewConfig
            {
                Header = new Header
                {
                    BgColor = MDLColors.Purple,
                    Title = "Typography",
                    SubTitle = "Since the Ice Cream Sandwich release, Roboto has been the standard typeface on Android. Since Froyo, Noto has been the standard typeface on Android for all languages not covered by Roboto. Noto is also the standard typeface for all languages on Chrome OS."
                },
            });
        }

        public IActionResult Shadows()
        {
            return View(new PageViewConfig
            {
                Header = new Header
                {
                    BgColor = MDLColors.Cyan,
                    Title = "Shadows",
                    SubTitle = "Shadows provide important visual cues about objects’ depth and directional movement. They are the only visual cue indicating the amount of separation between surfaces. An object’s elevation determines the appearance of its shadow."
                },
                RightOnHeader = false
            });
        }

    }
}
