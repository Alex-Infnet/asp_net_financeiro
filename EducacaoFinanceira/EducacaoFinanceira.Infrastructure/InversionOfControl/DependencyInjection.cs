using System;
using EducacaoFinanceira.Application.Interfaces;
using EducacaoFinanceira.Infrastructure.Data.Repository;
using EducacaoFinanceira.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EducacaoFinanceira.Infrastructure.InversionOfControl
{
	public class DependencyInjection
	{
		public static void Inject(IServiceCollection services, ConfigurationManager configuration)
		{
			services.AddScoped<ITipoInvestimentoRepository, TipoInvestimentoRepository>();
            services.AddScoped<ITipoInvestimentoService, TipoInvestimentoService>();

			services.AddDbContext<EducacaoFinanceiraDbContext>(options => options.UseSqlServer(
				configuration.GetConnectionString("DbConnection")
				));
        }
	}
}

