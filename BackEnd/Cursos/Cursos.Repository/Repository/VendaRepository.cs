using Cursos.Core.Model;
using Cursos.Repository.Interfaces;

namespace Cursos.Repository.Repository
{
    public class VendaRepository : DomainRepository<Venda>, IVendaRepository
    {
        public VendaRepository(ApplicationContext dbContext) : base(dbContext)
        {

        }
    }
}
