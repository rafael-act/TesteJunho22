using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RevendaVeiculos.Dominio.Contratos;
using RevendaVeiculos.Repositorio.Contexto;
using RevendaVeiculos.Repositorio.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RevendaVeiculos
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            var builder = new ConfigurationBuilder();

            builder.AddJsonFile("config.json", optional: false, reloadOnChange: true);

            Configuration = builder.Build();
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            var connectionstring = Configuration.GetConnectionString("RevendaVeiculosDB");
            services.AddDbContext<RevendaVeiculosContexto>(option =>
                                                    option.UseLazyLoadingProxies()
                                                          .UseMySql(connectionstring));
            //services.AddScoped<IEnderecoRepositorio, EnderecoRepositorio>();
            services.AddScoped<IMarcaRepositorio, MarcaRepositorio>();
            services.AddScoped<IProprietarioRepositorio, ProprietarioRepositorio>();
            // services.AddScoped<IUsuarioRepositorio, UsuarioRepositorio>();
            services.AddScoped<IVeiculoRepositorio, VeiculoRepositorio>();
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
