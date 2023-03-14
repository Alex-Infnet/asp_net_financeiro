using System;
using System.ComponentModel.DataAnnotations;
using Domain.Entities;
using Domain.Validators;

namespace Domain.ViewModels
{
	public class FaleConoscoViewModel
	{
		[Required(ErrorMessage = "O campo Nome deve ser preenchido")]
		[MaxLength(100, ErrorMessage = "O tamanho máximo do nome é 100 caracteres")]
		public string? Nome { get; set; }

        [Required(ErrorMessage = "O campo E-mail deve ser preenchido")]
        [MaxLength(100, ErrorMessage = "O tamanho máximo do email é 100 caracteres")]
		[RegularExpression("\\S*\\@\\S*", ErrorMessage = "Informe um e-mail válido")]
		[EmailValidator(ErrorMessage = "Apenas e-mails BR são aceitos")]
		public string? Email { get; set; }

        [Required(ErrorMessage = "O campo Conteúdo deve ser preenchido")]
        [MinLength(10, ErrorMessage = "O conteúdo do contato deve ser preenchido com pelo menos 10 caracteres")]
		public string? Conteudo { get; set; }

		public Contact FaleConosco()
		{
			return new Contact()
			{
				Name = Nome,
				Email = Email,
				Conteudo = Conteudo
            };
		}
        public FaleConoscoViewModel() { }
        public FaleConoscoViewModel(Contact contact)
		{
			Nome = contact.Name;
			Email = contact.Email;
			Conteudo = contact.Conteudo;
        }
    }
}

