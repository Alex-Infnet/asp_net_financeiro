using System;
using EducacaoFinanceira.Domain.Entities;
namespace EducacaoFinanceira.Application.Interfaces
{
	public interface ITipoInvestimentoService
	{
		IEnumerable<TipoInvestimento> GetAll();
	}
}

