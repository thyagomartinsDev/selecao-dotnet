using Cursos.Domain.Model;
using Cursos.Repository.Interfaces;

namespace Cursos.Repository.Repository
{
    public class CursoRepository : DomainRepository<Curso>, ICursoRepository
    {
        public CursoRepository(ApplicationContext dbContext) : base(dbContext)
        {

        }
    }
}
