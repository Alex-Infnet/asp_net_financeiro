using System;
namespace Domain.ViewModels
{
	public class BaseCurso
	{
		public int Id { get; set; }
		public string? Descricao { get; set; }
	}
	public class InscricaoCursoViewModel
	{
		public IEnumerable<BaseCurso> Cursos { get; set; }
		public string? Curso { get; set; }

        public bool Matutino { get; set; }
        public bool Vespertino { get; set; }
        public bool Noturno { get; set; }

        public string? Nome { get; set; }
		public string? Email { get; set; }
        public string? Telefone { get; set; }
		public string? CodigoAcesso { get; set; }
        public string? Bio { get; set; }
        public bool TermosAceite { get; set; }

        public InscricaoCursoViewModel()
		{
			Cursos = new List<BaseCurso>()
			{
				new BaseCurso() {Id = 1, Descricao = "Como investir na bolsa"},
				new BaseCurso() {Id = 2, Descricao = "Investindo em Renda fixa"},
			};
		}
    }
}

