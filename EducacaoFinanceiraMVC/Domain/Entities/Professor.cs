using System;
namespace Domain.Entities
{
	public class Professor
	{
		public int Id { get; set; }
		public string? Nome { get; set; }
		public string? Bio { get; set; }

        public ICollection<Curso>? Cursos { get; set; }
    }
}

