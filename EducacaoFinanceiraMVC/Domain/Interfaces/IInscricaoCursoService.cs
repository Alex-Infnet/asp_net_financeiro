using System;
using Domain.ViewModels;

namespace Domain.Interfaces
{
	public interface IInscricaoCursoService
	{
		void Create(InscricaoCursoViewModel inscricaoCursoViewModel);
	}
}

