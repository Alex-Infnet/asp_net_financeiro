﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Domain.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Cors;
using Domain.ViewModels;
using Microsoft.AspNetCore.Authorization;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [ApiController]
    [Authorize]
    public class TipoInvestimentoController : ControllerBase
    {
        public ITipoInvestimentoService _service { get; set; }
        public TipoInvestimentoController(ITipoInvestimentoService service)
        {
            _service = service;
        }
        [Route("/tipoinvestimento")]
        [HttpGet]
        public IActionResult Index()
        {
            return Ok(_service.GetAll());
        }
        [Route("/tipoinvestimento/new")]
        [HttpPost]
        [Authorize(Roles = "admin")]
        public IActionResult Create(TipoInvestimentoViewModel tipoInvestimentoViewModel)
        {
            _service.Create(tipoInvestimentoViewModel);
            return NoContent();
        }
        [Route("/tipoinvestimento")]
        [HttpPut]
        public IActionResult Update(TipoInvestimento tipoInvestimento)
        {
            _service.Update(tipoInvestimento);
            return NoContent();
        }
        [Route("/tipoinvestimento/{id}")]
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _service.Delete(id);
            return NoContent();
        }
    }
}

