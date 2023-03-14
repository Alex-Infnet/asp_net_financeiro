using System;
using System.ComponentModel.DataAnnotations;
using Domain.Entities;

namespace Domain.ViewModels
{
	public class TipoInvestimentoViewModel
	{
		public int Id { get; set; }
		[Required]
		[MaxLength(255, ErrorMessage = "O campo excede o tamanho máximo permitido")]
		public string? Descricao { get; set; }

		private bool _Active { get; set; }
		public string Status {
			get
			{
				return _Active ? "Ativo" : "Desativado";
			}
		}

		public bool Selected { get; set; }

        public TipoInvestimentoViewModel()
		{

		}

        public TipoInvestimentoViewModel(TipoInvestimento tipoInvestimento)
		{
			this.Id = tipoInvestimento.Id;
			this.Descricao = tipoInvestimento.Descricao;
			this.Selected = false;
			this._Active = tipoInvestimento.Active;
		}

		public static List<TipoInvestimentoViewModel> GetAll(List<TipoInvestimento> tipoInvestimentos)
		{
			var listTipo = new List<TipoInvestimentoViewModel>();
			foreach (var item in tipoInvestimentos)
			{
				listTipo.Add(new TipoInvestimentoViewModel(item));
			}
			return listTipo;
        }
    }
}

