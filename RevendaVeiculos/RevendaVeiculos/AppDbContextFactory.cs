using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using RevendaVeiculos.Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace RevendaVeiculos
{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<RevendaVeiculosContexto>
    {
        IConfigurationRoot configuration = new ConfigurationBuilder()
              //.SetBasePath(Directory.GetCurrentDirectory())
              .AddJsonFile("config.json", optional: false, reloadOnChange: true)
              .Build();


        public RevendaVeiculosContexto CreateDbContext(string[] args)
        {     // Criando manualmente
            var builder = new DbContextOptionsBuilder<RevendaVeiculosContexto>();
            var connectionString = configuration.GetConnectionString("RevendaVeiculosDB");
            builder
                .UseLazyLoadingProxies()
                .UseMySql(connectionString);

            return new RevendaVeiculosContexto(builder.Options);
        }
    }
}
