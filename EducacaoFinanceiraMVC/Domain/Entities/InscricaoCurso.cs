using System;
namespace Domain.Entities
{
	public class InscricaoCurso
	{
		public int Id { get; set; }
		public string? Curso { get; set; }
		public string? Nome { get; set; }
		public string? Email { get; set; }
        public string? Telefone { get; set; }
        public string? CodigoAcesso { get; set; }
		public string? Bio { get; set; }
	}
}

