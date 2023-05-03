using LABCOMPRAS22.Models;
using Microsoft.AspNetCore.Mvc;

namespace LABCOMPRAS22.Controllers
{
    public class ContasBancariasController : Controller
    {
        public IActionResult Index()
        {
          
            List<ContaBancaria> contas = Repositorio.Contas;
            return View(contas);
        }

        [HttpGet]
        public IActionResult NovaContaBancaria()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NovaContaBancaria(ContaBancaria NovaContaBancaria)
        {
            if (ModelState.IsValid)
            {
                return View("ContaBancariaCriada", NovaContaBancaria);
            }
            else
                return View();

        }

        [HttpPost]
        public IActionResult NovaConta(ContaBancaria contaBancaria)
        {
            Repositorio.AdicionarContaBancaria(contaBancaria);

            return View("ContaConfirmada" , contaBancaria);
        }

    }
}
