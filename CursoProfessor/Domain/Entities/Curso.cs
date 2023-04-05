using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
	public class Curso
	{
		public int Id { get; set; }
        [MaxLength(150)]
        public string? Descricao { get; set; }
        [MaxLength(50)]
        public string? Duracao { get; set; }

        public ICollection<Professor>? Professores { get; set; }
	}
}

