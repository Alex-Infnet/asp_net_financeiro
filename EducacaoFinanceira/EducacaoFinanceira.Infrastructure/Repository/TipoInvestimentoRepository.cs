using System;
using EducacaoFinanceira.Application.Interfaces;
using EducacaoFinanceira.Domain.Entities;

namespace EducacaoFinanceira.Infrastructure.Data.Repository
{
	public class TipoInvestimentoRepository : ITipoInvestimentoRepository
    {
        private readonly EducacaoFinanceiraDbContext _dbContext;
        public TipoInvestimentoRepository(EducacaoFinanceiraDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<TipoInvestimento> GetAll()
        {
            return _dbContext.TipoInvestimento.ToList();
        }
    }
}

