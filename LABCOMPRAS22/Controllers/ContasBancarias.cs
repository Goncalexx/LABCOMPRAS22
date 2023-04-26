using LABCOMPRAS22.Models;
using Microsoft.AspNetCore.Mvc;

namespace LABCOMPRAS22.Controllers
{
    public class ContasBancarias : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult NovaContaBancaria()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NovaContaBancaria(ContasBancarias NovaContaBancaria)
        {
            if (ModelState.IsValid)
            {
                return View("ContaBancariaCriada", NovaContaBancaria);
            }
            else
                return View();

        }


    }
}
