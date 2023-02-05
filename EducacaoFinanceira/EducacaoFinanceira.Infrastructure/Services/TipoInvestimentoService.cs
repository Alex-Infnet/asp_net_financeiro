using System;
using EducacaoFinanceira.Application.Interfaces;
using EducacaoFinanceira.Domain.Entities;

namespace EducacaoFinanceira.Infrastructure.Services
{
	public class TipoInvestimentoService : ITipoInvestimentoService
	{
        public readonly ITipoInvestimentoRepository _repository;
        public TipoInvestimentoService(ITipoInvestimentoRepository repository)
        {
            _repository = repository;
        }
        public IEnumerable<TipoInvestimento> GetAll()
        {
            return _repository.GetAll();
        }
    }
}

