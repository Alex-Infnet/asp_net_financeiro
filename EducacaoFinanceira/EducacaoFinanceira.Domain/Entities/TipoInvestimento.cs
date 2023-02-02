using System;
namespace EducacaoFinanceira.Domain.Entities
{
	public class TipoInvestimento
	{
        public int Id { get; set; }
        public string? Descricao { get; set; }
		public ModeloIr? ModeloIr { get; set; }
	}
}

