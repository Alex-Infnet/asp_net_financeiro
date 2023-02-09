using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EducacaoFinanceira.Application.Interfaces;

namespace Web.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ITipoInvestimentoService _tipoInvestimentoService;

    public HomeController(ILogger<HomeController> logger, ITipoInvestimentoService tipoInvestimentoService)
    {
        _logger = logger;
        _tipoInvestimentoService = tipoInvestimentoService;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        var tipoInvestimentos = _tipoInvestimentoService.GetAll();
        return Ok(tipoInvestimentos);
    }
}

