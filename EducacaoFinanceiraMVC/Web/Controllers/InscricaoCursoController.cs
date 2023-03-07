using Domain.Interfaces;
using Domain.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Web.Controllers
{
    public class BaseCurso
    {
        public int Id { get; set; }
        public string? Descricao { get; set; }
    }
    public class InscricaoCursoController : Controller
    {
        private readonly IInscricaCursoService _inscricao;
        public InscricaoCursoController(IInscricaCursoService inscricao)
        {
            _inscricao = inscricao;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            var viewModel = new InscricaoCursoViewModel();
            return View(viewModel);
        }

        public IActionResult New(InscricaoCursoViewModel inscricaoCursoViewModel)
        {
            //_inscricao.Create(inscricaoCursoViewModel);
            return View("Index",inscricaoCursoViewModel);
        }
    }
}

