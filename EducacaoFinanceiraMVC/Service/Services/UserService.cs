using System;
using Domain.Entities;
using Domain.Interfaces;

namespace Service.Services
{
    public class UserService : IUserService
    {
        private readonly InvestimentoDbContext _dbContext;
        public UserService(InvestimentoDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public User Find(string Email)
        {
            return _dbContext.user.First(u => u.Email == Email);
        }
        public void Create(string Email, string Password, string Nome)
        {
            var user = new User()
            {
                Email = Email,
                Name = Nome,
                Password = Password
            };
            _dbContext.user.Add(user);
            _dbContext.SaveChanges();
        }
    }
}

