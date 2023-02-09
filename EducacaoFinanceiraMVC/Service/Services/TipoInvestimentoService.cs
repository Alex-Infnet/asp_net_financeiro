using System;
using Domain.Entities;
using Domain.Interfaces;

namespace Service.Services
{
	public class TipoInvestimentoService : ITipoInvestimentoService
	{
		private readonly InvestimentoDbContext _dbContext;
		public TipoInvestimentoService(InvestimentoDbContext dbContext)
		{
			_dbContext = dbContext;
		}

        public List<TipoInvestimento> GetAll()
        {
			return _dbContext.tipoInvestimento.ToList();
        }
    }
}

