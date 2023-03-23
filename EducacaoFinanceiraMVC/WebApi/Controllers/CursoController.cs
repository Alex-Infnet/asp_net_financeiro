using System;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Service.Services;

namespace WebApi.Controllers
{
	public class CursoController : ControllerBase
	{
        private readonly ICursoService _cursoService;
        public CursoController(
            ICursoService cursoService)
        {
            _cursoService = cursoService;
        }
        [HttpGet]
        [Route("cursos")]
        public IActionResult Cursos()
        {
            return Ok(_cursoService.GetAll());
        }
    }
}

