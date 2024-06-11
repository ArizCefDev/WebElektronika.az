using Microsoft.AspNetCore.Mvc;

namespace WebElektronika.az.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
