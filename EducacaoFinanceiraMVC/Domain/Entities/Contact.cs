using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
	public class Contact
	{
		public int Id { get; set; }
		[MaxLength(250)]
		[Required]
		public string? Name { get; set; }
        [MaxLength(250)]
        [Required]
        public string? Email { get; set; }
        [Required]
        public string? Conteudo { get; set; }
	}
}

