using System;
namespace Domain.Entities
{
	public class Curso
	{
		public int Id { get; set; }
		public string? Descricao { get; set; }
		public string? Duracao { get; set; }
		
		public ICollection<Professor>? Professores { get; set; }
	}
}

