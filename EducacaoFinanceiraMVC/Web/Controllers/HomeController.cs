using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Domain.Entities;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult FaleConosco()
        {
            return View();
        }
        [HttpPost]
        public IActionResult FaleConosco(TipoInvestimento tipoInvestimento)
        {
            return View(tipoInvestimento);
        }
    }
}

