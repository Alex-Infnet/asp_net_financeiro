﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Web.Filters;
using Microsoft.AspNetCore.Mvc.Filters;
using Web.TagHelpers;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult FaleConosco()
        {
            return View();
        }
        [HttpPost]
        public IActionResult FaleConosco(Contact contact)
        {
            ViewBag.outputMessage = new FormOutputMessage()
            {
                Valid = false,
                Message = "Formulário enviado com sucesso"
            };
            return View(contact);
        }
        [ResultFilter]
        public IActionResult Filter()
        {
            return Ok(new User() { Email = "personal@gmail.com"});
        }
    }
}

