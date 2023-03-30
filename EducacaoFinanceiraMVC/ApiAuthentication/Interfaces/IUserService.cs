using System;
using ApiAuthentication.Models;

namespace ApiAuthentication.Interfaces
{
	public interface IUserService
	{
        User Find(string Email);
	}
}

