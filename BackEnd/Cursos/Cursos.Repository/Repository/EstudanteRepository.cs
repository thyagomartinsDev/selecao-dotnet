using Cursos.Core.Model;
using Cursos.Repository.Interfaces;

namespace Cursos.Repository.Repository
{
    public class EstudanteRepository : DomainRepository<Estudante>, IEstudanteRepository
    {
        public EstudanteRepository(ApplicationContext dbContext) : base(dbContext)
        {           

        }
    }
}
