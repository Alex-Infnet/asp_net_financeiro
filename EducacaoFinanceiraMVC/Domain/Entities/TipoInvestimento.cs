using System;
namespace Domain.Entities
{
	public class TipoInvestimento
	{
		public int Id { get; set; }
		public string? Descricao { get; set; }
		public bool Active { get; set; }
	}
}

