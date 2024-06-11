using Microsoft.AspNetCore.Mvc;

namespace WebElektronika.az.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
