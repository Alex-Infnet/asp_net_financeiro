using System;
using Microsoft.EntityFrameworkCore;
using EducacaoFinanceira.Domain.Entities;
namespace EducacaoFinanceira.Data.DB
{
	public class EFDbContext : DbContext
	{
        public EFDbContext(DbContextOptions options) : base(options){ }

        DbSet<ModeloIr> ModeloIr { get; set; }
        DbSet<ModeloIrOcorrencia> ModeloIrOcorrencia { get; set; }
        DbSet<TipoInvestimento> TipoInvestimento { get; set; }
        DbSet<Usuario> Usuario { get; set; }
    }
}

