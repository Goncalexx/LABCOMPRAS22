using Microsoft.AspNetCore.Mvc;

namespace LABCOMPRAS22.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Conceito()
        {
            return View();
        }
    }
}
