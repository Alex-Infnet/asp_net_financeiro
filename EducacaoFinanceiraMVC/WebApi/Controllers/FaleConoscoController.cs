using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Interfaces;
using Domain.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Service.Services;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [ApiController]
    public class FaleConoscoController : ControllerBase
    {
        private readonly IContactService _contactService;
        public FaleConoscoController(IContactService contactService)
        {
            _contactService = contactService;
        }
        [HttpGet]
        [Route("faleconosco")]
        public IActionResult Get()
        {
            return Ok(_contactService.All());
        }
        [HttpPost]
        [Route("faleconosco/contato")]
        public IActionResult Post(FaleConoscoViewModel faleConoscoViewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            _contactService.Create(faleConoscoViewModel.FaleConosco());
            return NoContent();
        }
    }
}

