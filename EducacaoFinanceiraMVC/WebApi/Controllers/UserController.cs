using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Service;
using Service.Services;
using System.Security.Cryptography;
using System.Text;
using Domain.Interfaces;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _service;
        private readonly TokenService _tokenService;
        public UserController(IUserService service, TokenService tokenService)
        {
            _service = service;
            _tokenService = tokenService;
        }
        private string GetSHA512Password(string Password)
        {
            return Encoding.ASCII.GetString(SHA512.HashData(Encoding.ASCII.GetBytes(Password)));
        }
        [HttpPost]
        [Route("user/login")]
        public IActionResult Authenticate(string Email, string Password)
        {
            var user = _service.Find(Email);
            if (user == null)
            {
                return BadRequest();
            }
            if (user.Password != GetSHA512Password(Password))
            {
                return Forbid();
            }
            return Ok(_tokenService.GenerateToken(user));
        }
        [HttpPost]
        [Route("user/signup")]
        public IActionResult Signup(string Email, string Password)
        {
            var _Password = GetSHA512Password(Password);
            _service.Create(Email, _Password, Email);
            return NoContent();
        }
    }
}

