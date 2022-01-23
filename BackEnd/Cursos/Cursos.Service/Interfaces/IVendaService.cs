using Cursos.Service.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cursos.Service.Interfaces
{
    public interface IVendaService
    {
        Task<DtoVenda> Inserir(DtoVenda model);
        Task<DtoVenda> Alterar(DtoVenda model);
        Task<IEnumerable<DtoVenda>> BuscarTodos();
        Task<DtoVenda> BuscarPorId(int idVenda);
        Task<bool> Excluir(int idVenda);
    }
}
