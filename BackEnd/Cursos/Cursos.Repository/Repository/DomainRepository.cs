using Cursos.Core.Interfaces;
using Cursos.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Cursos.Repository.Repository
{
    public class DomainRepository<TEntidade> : RepositoryBase<TEntidade>, IDomainRepository<TEntidade> where TEntidade : class, IIdentityEntity
    {
        protected DomainRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
