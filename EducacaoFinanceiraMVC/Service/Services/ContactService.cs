using System;
using Domain.Entities;
using Domain.Interfaces;

namespace Service.Services
{
    public class ContactService : IContactService
    {
        private readonly InvestimentoDbContext _dbContext;
        public ContactService(InvestimentoDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Create(Contact contact)
        {
            _dbContext.contact.Add(contact);
            _dbContext.SaveChanges();
        }
    }
}

