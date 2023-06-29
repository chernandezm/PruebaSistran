using Microsoft.EntityFrameworkCore;
using PruebaOperador.Api.BusinessServices.Command;
using PruebaOperador.Api.BusinessServices.Invoker;
using PruebaOperador.Api.BusinessServices.Services;
using PruebaOperador.Api.Repository.Context;
using PruebaOperador.Api.Repository.Entity;
using PruebaOperador.Api.Repository.Repository;
using PruebaOperador.Api.Services.Command;
using PruebaOperador.Api.Services.Invoker;
using PruebaOperador.Api.Services.Repository;
using PruebaOperador.Api.Services.Services;


namespace PruebaOperador.Api
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
            services.AddControllers();
            services.AddScoped<IRepositoryGeneric<Persona>, PersonaRepository>();
            services.AddDbContext<PruebaOperadorContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddScoped<IPersonaService, PersonaService>();
            services.AddScoped<IPersonaCommand, PersonaCommand>();
            services.AddScoped<IPersonaInvoker, PersonaIncoker>();
            services.AddControllers();
            services.AddSwaggerGen();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
