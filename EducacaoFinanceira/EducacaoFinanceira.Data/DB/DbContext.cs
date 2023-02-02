using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using EducacaoFinanceira.Data.DB;

namespace EducacaoFinanceira.Data
{

    public class AppDbContextFactory : IDesignTimeDbContextFactory<EFDbContext>
    {
        public EFDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<EFDbContext>();
            optionsBuilder.UseSqlServer("Server=192.168.0.27; Database=educacao_financeira; User Id=sa; Password=Abc123456; TrustServerCertificate=true;");
            return new EFDbContext(optionsBuilder.Options);
        }
    }
}

