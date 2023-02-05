using System;
using EducacaoFinanceira.Application.Interfaces;
using EducacaoFinanceira.Domain.Entities;
using EducacaoFinanceira.Infrastructure.Data;

namespace EducacaoFinanceira.Infrastructure.Services
{
	public class TipoInvestimentoService : ITipoInvestimentoService
	{
        public readonly EFDbContext dbContext;
        public TipoInvestimentoService(EFDbContext _dbContext)
        {
            dbContext = _dbContext;
        }
        public List<TipoInvestimento> GetAll()
        {
            return dbContext.TipoInvestimento.ToList();
        }
    }
}

