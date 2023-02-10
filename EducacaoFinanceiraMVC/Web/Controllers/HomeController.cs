using System.Diagnostics;
using System.Globalization;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

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
        var investimentos = _tipoInvestimentoService.GetAll();
        return View(investimentos);
    }

    [Route("home/filtro/active/{active}")]
    public IActionResult Filtro(bool active)
    {
        var investimentos = new List<TipoInvestimento>();
        if (active)
        {
            investimentos = _tipoInvestimentoService.GetAllActive();
        }
        else
        {
            investimentos = _tipoInvestimentoService.GetAll();
        }
        return View("Index",investimentos);
    }
    [Route("home/search/q/{search}")]
    public IActionResult Search(string search)
    {
        var investimentos = _tipoInvestimentoService.GetByDescricao(search);
        return View("Index", investimentos);
    }

    [Route("home/data/{data}")]
    public IActionResult Data(string data)
    {
        HttpContext.Session.SetString("Data", data);
        return View("Data", data);
    }

    [Route("home/resultado")]
    public IActionResult Resultado()
    {
        var Data = DateTime.ParseExact(HttpContext.Session.GetString("Data"), "ddMMyyyy", CultureInfo.InvariantCulture);

        return View("Resultado", Data.ToShortDateString());
    }

    public IActionResult Privacy()
    {
        return View();
    }
}

