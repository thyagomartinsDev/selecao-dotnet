using Cursos.Domain.Interfaces;

namespace Cursos.Repository.Interfaces
{
    public interface IDomainRepository<TEntidade> : IRepositoryBase<TEntidade> where TEntidade : class, IIdentityEntity
    {
    }
}
