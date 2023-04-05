using System;
using Domain.Entities;

namespace Domain.Interfaces
{
	public interface ICursoService
	{
		IList<Curso> GetAll();
	}
}

