using System;
using Domain.Entities;
using Domain.Interfaces;
using Domain.ViewModels;

namespace Service.Services
{
    public class ContactService : IContactService
    {
        private readonly InvestimentoDbContext _dbContext;
        public ContactService(InvestimentoDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IList<FaleConoscoViewModel> All()
        {
            var contacts = _dbContext.contact.ToList();
            var listContacts = new List<FaleConoscoViewModel>();
            contacts.ForEach(c =>
            {
                listContacts.Add(new FaleConoscoViewModel(c));
            });
            return listContacts;
        }

        public void Create(Contact contact)
        {
            _dbContext.contact.Add(contact);
            _dbContext.SaveChanges();
        }
    }
}

