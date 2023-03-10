using System;
using Domain.Entities;
using Domain.Interfaces;
using Domain.ViewModels;

namespace Service.Services
{
	public class TipoInvestimentoService : ITipoInvestimentoService
	{
		private readonly InvestimentoDbContext _dbContext;
		public TipoInvestimentoService(InvestimentoDbContext dbContext)
		{
			_dbContext = dbContext;
		}

        public IList<TipoInvestimentoViewModel> GetAll()
        {
            var tipoInvestimentos = _dbContext.tipoInvestimento.ToList();

            return TipoInvestimentoViewModel.GetAll(tipoInvestimentos);
        }

        public List<TipoInvestimento> GetAllActive()
        {
            return _dbContext.tipoInvestimento.Where(t => t.Active).ToList();
        }

        public List<TipoInvestimento> GetByDescricao(string Descricao)
        {
            return _dbContext.tipoInvestimento.Where(t => t.Descricao.ToLower() == Descricao.ToLower()).ToList();
        }
    }
}

