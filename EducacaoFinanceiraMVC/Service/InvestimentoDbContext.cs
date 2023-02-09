using System;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;

namespace Service
{
	public class InvestimentoDbContext : DbContext
	{
        public InvestimentoDbContext(DbContextOptions options) : base(options) { }

        public DbSet<TipoInvestimento> tipoInvestimento { get; set; }
	}
}

