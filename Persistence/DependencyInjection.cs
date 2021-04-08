using Application.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Context;
using System.IO;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
	public static class DependencyInjection
	{
		public static void AddPersistence(this IServiceCollection services, IConfiguration configuration)
		{
			var configreader = new ConfigurationReader();
			configreader.LoadXML($"{ Directory.GetParent(Directory.GetCurrentDirectory())}/dsconfig.xml");
			var sb = new StringBuilder();
			sb.Append($"{ configreader.ReadFromFile("url")}; User Id = { configreader.ReadFromFile("username") }; Password = { configreader.ReadFromFile("password")}");

			services.AddDbContext<ApplicationDbContext>(options =>
				options.UseOracle(sb.ToString(),
					b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));
			services.AddScoped<IApplicationDbContext>(provider => provider.GetService<ApplicationDbContext>());
		}
	}
}