using System.Collections.Generic;
using System.Threading.Tasks;
using Cursos.Service.Dtos;

namespace Cursos.Service.Interfaces
{
    public interface IEstudanteService
    {
        Task<DtoEstudante> Inserir(DtoEstudante model);
        Task<DtoEstudante> Alterar(DtoEstudante model);
        Task<IEnumerable<DtoEstudante>> BuscarTodos();
        Task<DtoEstudante> BuscarPorId(int idEstudante);
        Task<bool> Excluir(int idEstudante);
    }
}
