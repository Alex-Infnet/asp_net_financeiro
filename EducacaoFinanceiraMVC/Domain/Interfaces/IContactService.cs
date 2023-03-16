using System;
using Domain.Entities;
using Domain.ViewModels;

namespace Domain.Interfaces
{
	public interface IContactService
	{
		void Create(Contact contact);
		IList<FaleConoscoViewModel> All();

    }
}

