﻿using System;
namespace ApiAuthentication.Models
{
	public class User
	{
		public int Id { get; set; }
		public string? Nome { get; set; }
		public string? Email { get; set; }
		public string? Password { get; set; }
		public string? Role { get; set; }
	}
}

