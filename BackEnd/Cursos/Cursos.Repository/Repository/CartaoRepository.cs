using Cursos.Core.Model;
using Cursos.Repository.Interfaces;

namespace Cursos.Repository.Repository
{
    public class CartaoRepository : DomainRepository<Cartao>, ICartaoRepository
    {
        public CartaoRepository(ApplicationContext dbContext) : base(dbContext)
        {

        }
    }
}
