using System;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Service.Services
{
    public class CursoService : ICursoService
    {
        private readonly InvestimentoDbContext _dbContext;
        public CursoService(InvestimentoDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public ICollection<Curso> GetAll()
        {
            return _dbContext.curso
                .Include(c => c.Professores)
                .ToList();
        }
    }
}

