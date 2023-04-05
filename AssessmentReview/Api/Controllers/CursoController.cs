using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Domain.Entities;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api.Controllers
{
    [ApiController]
    public class CursoController : ControllerBase
    {
        private readonly ICursoService _cursoService;
        public CursoController(ICursoService cursoService)
        {
            _cursoService = cursoService;
        }

        [Route("/cursos")]
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_cursoService.Get());
        }
        [Route("/cursos/create")]
        [HttpPost]
        public IActionResult Post(string Descricao, string Duracao)
        {
            _cursoService.Create(Descricao, Duracao);
            return Ok(_cursoService.Get());
        }
        [Route("/cursos/update")]
        [HttpPut]
        public IActionResult Put([FromBody] Curso curso)
        {
            _cursoService.Update(curso);
            return Ok(_cursoService.Get());
        }
        [Route("/cursos/delete/{Id}")]
        [HttpDelete]
        public IActionResult Delete(int Id)
        {
            _cursoService.Delete(Id);
            return Ok(_cursoService.Get());
        }
    }
}

