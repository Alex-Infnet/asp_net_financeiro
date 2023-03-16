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

        public void Create(TipoInvestimentoViewModel tipoInvestimentoViewModel)
        {
            var tipoInvestimento = new TipoInvestimento()
            {
                Active = tipoInvestimentoViewModel.Status == "Ativo",
                Descricao = tipoInvestimentoViewModel.Descricao
            };
            _dbContext.tipoInvestimento.Add(tipoInvestimento);
            _dbContext.SaveChanges();
        }

        public void Delete(int Id)
        {
            var tipoInvestimento = _dbContext.tipoInvestimento.Where(t => t.Id == Id).First();
            _dbContext.tipoInvestimento.Remove(tipoInvestimento);
            _dbContext.SaveChanges();
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

        public void Update(TipoInvestimento tipoInvestimento)
        {
            _dbContext.tipoInvestimento.Update(tipoInvestimento);
            _dbContext.SaveChanges();
        }
    }
}

