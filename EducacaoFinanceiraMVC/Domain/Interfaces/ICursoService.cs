using System;
using Domain.Entities;

namespace Domain.Interfaces
{
	public interface ICursoService
	{
		ICollection<Curso> GetAll();
	}
}

