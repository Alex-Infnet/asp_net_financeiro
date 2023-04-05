using System;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Service.Services
{
	public class CursoService : ICursoService
    {
        private readonly CursoDbContext _cursoDbContext;
        public CursoService(CursoDbContext cursoDbContext)
        {
            _cursoDbContext = cursoDbContext;
        }
        public IList<Curso> GetAll()
        {
            return _cursoDbContext.cursos
                .Include(c => c.Professores)
                .ToList();
        }
    }
}

