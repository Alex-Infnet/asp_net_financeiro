using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EducacaoFinanceira.Application.Interfaces;
using EducacaoFinanceira.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Web.Controllers
{
    public class TipoInvestimentoController : Controller
    {
        private readonly ITipoInvestimentoService _tipoInvestimentoService;
        public TipoInvestimentoController(ITipoInvestimentoService tipoInvestimentoService)
        {
            _tipoInvestimentoService = tipoInvestimentoService;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            var tiposInvestimento = _tipoInvestimentoService.GetAll();
            return View(TipoInvestimentoViewModel.TiposInvestimento(tiposInvestimento.ToList()));
        }
    }
}

