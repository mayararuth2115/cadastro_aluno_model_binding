using Microsoft.AspNetCore.Mvc;
using CadastroAluno.Models;

namespace CadastroAluno.Controllers
{
    public class AlunoController : Controller
    {
        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Aluno aluno)
        {
            if (ModelState.IsValid)
            {
                return View("Confirmacao", aluno);
            }

            return View(aluno);
        }
    }
}
