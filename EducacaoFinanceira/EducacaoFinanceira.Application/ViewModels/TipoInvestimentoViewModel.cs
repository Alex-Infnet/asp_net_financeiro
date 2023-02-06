using System;
using EducacaoFinanceira.Domain.Entities;

namespace EducacaoFinanceira.Application.ViewModels
{
	public class TipoInvestimentoViewModel
	{
		public string? Descricao { get; set; }
		public string? ModeloIrDescricao { get; set; }
		public TipoInvestimentoViewModel(TipoInvestimento tipoInvestimento)
		{
			Descricao = tipoInvestimento.Descricao;
            ModeloIrDescricao = (tipoInvestimento.ModeloIr != null) ? tipoInvestimento.ModeloIr.Descricao : "Isento";
		}
		public static List<TipoInvestimentoViewModel> TiposInvestimento(List<TipoInvestimento> tipoInvestimentos)
		{
			var listTiposInvestimento = new List<TipoInvestimentoViewModel>();
			tipoInvestimentos.ForEach(t => listTiposInvestimento.Add(new TipoInvestimentoViewModel(t)));
			return listTiposInvestimento;
		}
	}
}

