using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Domain.Interfaces;
using Domain.Entities;

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

        // Lista de cursos
        [Route("/cursos")]
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_cursoService.GetAll());
        }

        // Curso especifico
        [Route("/cursos/{id}")]
        [HttpGet]
        public IActionResult GetCurso(int id)
        {
            return Ok(_cursoService.Get(id));
        }

        // Criar um curso
        [HttpPost]
        [Route("/cursos/create")]
        public IActionResult Create([FromBody] Curso curso)
        {
            _cursoService.Create(curso);
            return NoContent();
        }

        // Atualizar um curso
        [HttpPut]
        [Route("/cursos/update")]
        public IActionResult Update([FromBody] Curso curso)
        {
            _cursoService.Update(curso);
            return NoContent();
        }

        // Deletar um curso
        [HttpDelete]
        [Route("/cursos/{id}")]
        public IActionResult Delete(int id)
        {
            _cursoService.Delete(id);
            return NoContent();
        }
    }
}

