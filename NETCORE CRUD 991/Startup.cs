using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NETCORE_CRUD_991.Models.Abstract;
using NETCORE_CRUD_991.Models.Business;
using NETCORE_CRUD_991.Models.DAL;

namespace NETCORE_CRUD_991
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            var conexion = Configuration["ConnectionStrings:conexion_sqlServer"];
            services.AddDbContext<DbContextPrueba>(options => options.UseSqlServer(conexion));
           
            services.AddScoped<IClienteBusiness, ClienteBusiness>();
            services.AddScoped<IPaqueteBusiness, PaqueteBusiness>();
            services.AddScoped<ITransportadorasBusiness, TransportadorasBusiness>();
            services.AddScoped<ITipoMercanciaBusiness, TipoMercanciaBusiness>();
            services.AddScoped<IValorLibraBusiness, ValorLibraBusiness>();

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
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Clientes}/{action=Index}/{id?}");
            });
        }
    }
}
