using System;
using Domain.Entities;

namespace Domain.Interfaces
{
	public interface IUserService
	{
        User Find(string Email);
		void Create(string Email, string Password, string Nome);
		IList<User> GetAll();
	}
}

