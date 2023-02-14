using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Service;

namespace Service
{
	public class InvestimentoDbFactory : IDesignTimeDbContextFactory<InvestimentoDbContext>
    {
		public InvestimentoDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<InvestimentoDbContext>();
            optionsBuilder.UseSqlServer(
                "Server=192.168.0.27; Database=investimento; User Id=sa; Password=Abc123456; TrustServerCertificate=true;"
                );
            return new InvestimentoDbContext(optionsBuilder.Options);
        }
    }
}

