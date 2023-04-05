using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Service
{
	public class CursoDbFactory : IDesignTimeDbContextFactory<CursoDbContext>
    {
        public CursoDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<CursoDbContext>();
            optionsBuilder.UseSqlServer(
                "Server=192.168.0.27; Database=curso_assessment; User Id=sa; Password=Abc123456; TrustServerCertificate=true;"
                );
            return new CursoDbContext(optionsBuilder.Options);
        }
    }
}

