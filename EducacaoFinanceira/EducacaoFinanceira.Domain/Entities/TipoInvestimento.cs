using System;
using EducacaoFinanceira.Domain.Enums;

namespace EducacaoFinanceira.Domain.Entities
{
	public class TipoInvestimento
	{
        public int Id { get; set; }
        public string? Descricao { get; set; }
		public ModeloIr? ModeloIr { get; set; }
		public TipoInvestimentoStatus Status { get; set; }
	}
}

