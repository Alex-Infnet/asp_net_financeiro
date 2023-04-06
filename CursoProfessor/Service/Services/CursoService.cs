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

        public void Create(Curso curso)
        {
            _cursoDbContext.cursos.Add(curso);
            _cursoDbContext.SaveChanges();
        }

        public void Delete(int Id)
        {
            var curso = _cursoDbContext.cursos.First(c => c.Id == Id);
            _cursoDbContext.cursos.Remove(curso);
            _cursoDbContext.SaveChanges();
        }

        public Curso Get(int Id)
        {
            return _cursoDbContext.cursos
                .Include(c => c.Professores)
                .First(c => c.Id == Id);
        }

        public void Update(Curso curso)
        {
            _cursoDbContext.cursos.Update(curso);
            _cursoDbContext.SaveChanges();
        }
    }
}

