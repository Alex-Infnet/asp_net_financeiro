using System;
using Domain.Entities;

namespace Domain.Interfaces
{
	public interface ITipoInvestimentoService
	{
		List<TipoInvestimento> GetAll();
	}
}

