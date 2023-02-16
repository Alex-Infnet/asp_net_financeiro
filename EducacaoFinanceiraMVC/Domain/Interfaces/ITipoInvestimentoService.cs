using System;
using Domain.Entities;
using Domain.ViewModels;

namespace Domain.Interfaces
{
	public interface ITipoInvestimentoService
	{
		IList<TipoInvestimentoViewModel> GetAll();
        List<TipoInvestimento> GetAllActive();
        List<TipoInvestimento> GetByDescricao(string Descricao);
    }
}

