using Cursos.Repository;
using Cursos.Repository.Interfaces;
using Cursos.Repository.Repository;
using Cursos.Service;
using Cursos.Service.Concretes;
using Cursos.Service.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using SendGrid.Extensions.DependencyInjection;

namespace Cursos.API
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
            var connection = Configuration["ConexaoSqlite:SqliteConnectionString"];
            services.AddDbContext<ApplicationContext>(options =>
                options.UseSqlite(connection)
            );

            services.AddControllers();
            services.AddScoped<IEstudanteService, EstudanteService>();
            services.AddScoped<IEstudanteRepository, EstudanteRepository>();
            services.AddScoped<ICursoService, CursoService>();
            services.AddScoped<ICursoRepository, CursoRepository>();
            services.AddScoped<ICartaoService, CartaoService>();
            services.AddScoped<ICartaoRepository, CartaoRepository>();
            services.AddScoped<IMatriculaService, MatriculaService>();
            services.AddScoped<IMatriculaRepository, MatriculaRepository>();
            services.AddScoped<IVedaService, VendaService>();
            services.AddScoped<IVendaRepository, VendaRepository>();
            services.AddSendGrid(options =>
            options.ApiKey = Configuration.GetSection("Notification:SendGridAPIKey").Value
                );
            services.AddTransient<IEmailService, EmailService>();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Cursos.API", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Cursos.API v1"));
            }

            app.UseCors(x => x
               .AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader());

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
