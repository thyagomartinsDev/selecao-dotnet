using Cursos.Service.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cursos.Service.Interfaces
{
    public interface ICartaoService
    {
        Task<DtoCartao> Inserir(DtoCartao model);
        Task<DtoCartao> Alterar(DtoCartao model);
        Task<IEnumerable<DtoCartao>> BuscarTodos();
        Task<DtoCartao> BuscarPorId(int idCartao);
        Task<bool> Excluir(int idCartao);
        Task<IEnumerable<DtoCartao>> BuscarPorIdEstudante(int idEstudante);
    }
}
