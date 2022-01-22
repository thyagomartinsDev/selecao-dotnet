using Cursos.Service.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cursos.Service.Interfaces
{
    public interface IMatriculaService
    {
        Task<DtoMatricula> Inserir(DtoMatricula model);
        Task<DtoMatricula> Alterar(DtoMatricula model);
        Task<IEnumerable<DtoMatricula>> BuscarTodos();
        Task<DtoMatricula> BuscarPorId(int idMatricula);
        Task<bool> Excluir(int idMatricula);
    }
}
