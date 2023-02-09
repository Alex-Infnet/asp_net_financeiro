using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace EducacaoFinanceira.Infrastructure.Data
{   
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<EducacaoFinanceiraDbContext>
    {
        public EducacaoFinanceiraDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<EducacaoFinanceiraDbContext>();

            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("DbConnection"));
            return new EducacaoFinanceiraDbContext(optionsBuilder.Options);
        }
    }
}

