using Cursos.Repository.Interfaces;
using Cursos.Repository.Repository;
using Cursos.Service;
using Cursos.Service.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Cursos.IoC.InicializaSetup
{
    public class SetupServicoIoC
    {
        public static void RegisterServices(IServiceCollection services)
        {

            services.AddScoped<IEstudanteService, EstudanteService>();
        }
    }
}
