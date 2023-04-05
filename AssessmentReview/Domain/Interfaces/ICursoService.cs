using System;
using Domain.Entities;

namespace Domain.Interfaces
{
	public interface ICursoService
	{
		List<Curso> Get();
		void Create(string Descricao, string Duracao);
		void Delete(int Id);
		void Update(Curso curso);
	}
}

