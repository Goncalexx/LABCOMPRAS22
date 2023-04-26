using Microsoft.AspNetCore.Mvc;
using LABCOMPRAS22.Models;

namespace LABCOMPRAS22.Controllers
{
    public class DespesasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult NovaDespesa()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NovaDespesa(Despesa novaDespesa)
        {
            if (ModelState.IsValid)
            {
                return View("DespesaConfirmada", novaDespesa);
            }
            else
                return View();

        }
    }
}
