using System;
using ApiAuthentication.Interfaces;
using ApiAuthentication.Models;

namespace ApiAuthentication.Services
{
    public class UserService : IUserService
    {
        private List<User> users { get; set; }
        public UserService()
        {
            users = new List<User>();
            users.Add(new User() { Email = "alexandre@infnet.edu.br", Password = "alexandre", Role = "" });
            users.Add(new User() { Email = "outronome@infnet.edu.br", Password = "outronome", Role = "" });
        }
        public User Find(string Email)
        {
            return users.First(u => u.Email == Email);
        }
    }
}

