using System;
using Domain.Interfaces;
using Domain.Entities;

namespace Service.Services
{
    public class CursoService : ICursoService
    {
        /* Dados fake - deve ser substituido pelo DBContext
         * 
         */
        private List<Curso> cursos { get; set; }
        public CursoService()
        {
            cursos = new List<Curso>();
            cursos.Add(new Curso() { Id = 1, Descricao = "Curso A", Duracao = "10 aulas" });
            cursos.Add(new Curso() { Id = 2, Descricao = "Curso B", Duracao = "5 aulas" });
            cursos.Add(new Curso() { Id = 3, Descricao = "Curso C", Duracao = "20 aulas" });
        }


        public void Create(string Descricao, string Duracao)
        {
            var curso = new Curso()
            {
                Id = 4,
                Descricao = Descricao,
                Duracao = Duracao
            };
            cursos.Add(curso);
        }

        public void Delete(int Id)
        {
            cursos.RemoveAt(Id - 1);
        }

        public List<Curso> Get()
        {
            return cursos;
        }

        public void Update(Curso curso)
        {
            var _curso = cursos.First(c => c.Id == curso.Id);
            _curso.Descricao = curso.Descricao;
            _curso.Duracao = curso.Duracao;
            cursos.RemoveAt(curso.Id - 1);
            cursos.Add(_curso);
        }
    }
}

