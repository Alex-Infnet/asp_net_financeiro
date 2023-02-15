using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Domain.Interfaces;
using Domain.ViewModels;
using System.Runtime.Serialization.Formatters.Binary;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Microsoft.Extensions.Caching.Memory;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Web.Controllers
{
    public class InvestimentoController : Controller
    {
        private readonly IMemoryCache _memoryCache;
        private readonly ITipoInvestimentoService _tipoInvestimentoService;
        public InvestimentoController(
            ITipoInvestimentoService tipoInvestimentoService,
            IMemoryCache memoryCache)
        {
            _tipoInvestimentoService = tipoInvestimentoService;
            _memoryCache = memoryCache;
        }

        private void SetSessionList(List<int> Selected)
        {
            HttpContext.Session.SetString("Selected", JsonConvert.SerializeObject(Selected));
        }

        private List<int> GetSessionList()
        {
            var selectedList = HttpContext.Session.GetString("Selected");
            if (!string.IsNullOrEmpty(selectedList))
            {
                return JsonConvert.DeserializeObject<List<int>>(HttpContext.Session.GetString("Selected"));
            }
            return new List<int>();
        }

        private IList<TipoInvestimentoViewModel> GetOrCreateFromCache()
        {
            return _memoryCache.GetOrCreate<IList<TipoInvestimentoViewModel>>("InvestimentosCache", settings =>
            {
                settings.AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(20);
                settings.SlidingExpiration = TimeSpan.FromSeconds(20);

                return _tipoInvestimentoService.GetAll();
            });
        }

        [Route("/investimento/listadeinvestimentos")]
        public IActionResult ListaDeInvestimentos()
        {
            var Selected = this.GetSessionList();
            if (Selected.Count > 0)
            {
                var all = GetOrCreateFromCache().Where(t => Selected.Contains(t.Id)).ToList();
                return View(all);
            }
            return View(GetOrCreateFromCache());
        }
        [HttpPost]
        [Route("/investimento/selecionar")]
        public IActionResult Selecionar(List<int> Selected)
        {
            if (Selected.Count > 0)
            {
                this.SetSessionList(Selected);
            }
            var all = GetOrCreateFromCache().Where(t => Selected.Contains(t.Id)).ToList();

            return View(all);
        }
    }
}

