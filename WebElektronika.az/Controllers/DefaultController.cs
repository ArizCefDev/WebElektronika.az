using Microsoft.AspNetCore.Mvc;
using WebElektronika.az.Business.Abstract;
using WebElektronika.az.DTO;

namespace WebElektronika.az.Controllers
{
    public class DefaultController : Controller
    {
        private readonly ITechnologyService _technologyService;

        public DefaultController(ITechnologyService technologyService)
        {
            _technologyService = technologyService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(TechnologyDTO p)
        {
            _technologyService.Insert(p);
            return RedirectToAction("Index");
        }
    }
}
