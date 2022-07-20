using Cursos.Domain.Model;
using Cursos.Repository.Interfaces;

namespace Cursos.Repository.Repository
{
    public class MatriculaRepository : DomainRepository<Matricula>, IMatriculaRepository
    {
        public MatriculaRepository(ApplicationContext dbContext) : base(dbContext)
        {

        }
    }
}
