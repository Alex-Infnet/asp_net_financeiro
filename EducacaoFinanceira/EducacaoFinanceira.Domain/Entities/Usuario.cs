﻿using System;
namespace EducacaoFinanceira.Domain.Entities
{
	public class Usuario
	{
        public int Id { get; set; }
        public string? Nome { get; set; }
		public string? Email { get; set; }
		public string? Password { get; set; }
	}
}

