using System;
using Microsoft.EntityFrameworkCore;
using EducacaoFinanceira.Domain.Entities;

namespace EducacaoFinanceira.Infrastructure
{
	public class EducacaoFinanceiraDbContext : DbContext
	{
        public EducacaoFinanceiraDbContext(DbContextOptions options) : base(options){ }

        public DbSet<ModeloIr> ModeloIr { get; set; }
        public DbSet<ModeloIrOcorrencia> ModeloIrOcorrencia { get; set; }
        public DbSet<TipoInvestimento> TipoInvestimento { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
    }
}

