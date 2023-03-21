using System;
namespace Domain.ViewModels
{
	public class UserSignViewModel
	{
		public string Email { get; set; }
		public string Password { get; set; }
		public UserSignViewModel()
		{
			Email = "";
			Password = "";
		}
	}
}

