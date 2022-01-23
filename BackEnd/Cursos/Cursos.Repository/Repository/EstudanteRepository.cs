using Cursos.Core.Model;
using Cursos.Repository.Interfaces;
using System.Threading.Tasks;

namespace Cursos.Repository.Repository
{
    public class EstudanteRepository : DomainRepository<Estudante>, IEstudanteRepository
    {
        public EstudanteRepository(ApplicationContext dbContext) : base(dbContext)
        {           

        }
    }
}
