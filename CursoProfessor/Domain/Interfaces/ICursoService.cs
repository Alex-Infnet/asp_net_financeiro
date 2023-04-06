using System;
using Domain.Entities;

namespace Domain.Interfaces
{
	public interface ICursoService
	{
		// Recuperar todos os cursos
		IList<Curso> GetAll();

        // Recuperar um curso
        Curso Get(int Id);

		// Criar um curso
		void Create(Curso curso);

		// Atualizar um curso
		void Update(Curso curso);

		// Excluir um curso
		void Delete(int Id);
	}
}

