using System;
using EducacaoFinanceira.Domain.Entities;

namespace EducacaoFinanceira.Application.Interfaces
{
	public interface ITipoInvestimentoRepository
	{
		IEnumerable<TipoInvestimento> GetAll();
	}
}

