using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
	public class Professor
	{
		public int Id { get; set; }
		[MaxLength(150)]
		public string? Nome { get; set; }
		public string? Bio { get; set; }

		public ICollection<Curso>? Cursos { get; set; }
	}
}

