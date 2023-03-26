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
using Domain.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _service;
        private readonly TokenService _tokenService;
        private readonly IConfiguration _configuration;
        private readonly ICursoService _cursoService;
        public UserController(
            IUserService service,
            TokenService tokenService,
            IConfiguration configuration,
            ICursoService cursoService)
        {
            _service = service;
            _tokenService = tokenService;
            _configuration = configuration;
            _cursoService = cursoService;
        }
        private string GetSHA512Password(string Password)
        {
            return Encoding.ASCII.GetString(SHA512.HashData(Encoding.ASCII.GetBytes(Password)));
        }
        [HttpGet]
        [Route("user")]
        public IActionResult GetAll()
        {
            return Ok(_service.GetAll());
        }
        [HttpPost]
        [Route("user/login")]
        public IActionResult Authenticate([FromBody] UserSignViewModel usersign)
        {
            var user = _service.Find(usersign.Email);
            if (user == null)
            {
                return BadRequest();
            }
            if (user.Password != GetSHA512Password(usersign.Password))
            {
                return Forbid();
            }
            return Ok(_tokenService.GenerateToken(user, _configuration.GetValue("TokenSecret", "$")));
        }
        [HttpPost]
        [Route("user/signup")]
        public IActionResult Signup([FromBody] UserSignViewModel usersign)
        {
            var _Password = GetSHA512Password(usersign.Password);
            _service.Create(usersign.Email, _Password, usersign.Email);
            return NoContent();
        }
    }
}

