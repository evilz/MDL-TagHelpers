using Microsoft.AspNetCore.Mvc;

namespace MaterialDesignLite.WebSample.Controllers
{
    public class MainController : Controller
    {
        public IActionResult Path(string path)
        {
            
            if (string.IsNullOrWhiteSpace(path))
            {
                path = "Index";
            }
            path = path.Trim('/');
            return View(path);

        }
    }
}
