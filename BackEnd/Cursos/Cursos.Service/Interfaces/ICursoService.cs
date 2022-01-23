using Cursos.Service.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cursos.Service.Interfaces
{
    public interface ICursoService
    {
        Task<DtoCurso> Inserir(DtoCurso model);
        Task<DtoCurso> Alterar(DtoCurso model);
        Task<IEnumerable<DtoCurso>> BuscarTodos();
        Task<DtoCurso> BuscarPorId(int idEstudante);
        Task<bool> Excluir(int idEstudante);
        Task<IEnumerable<DtoCurso>> BuscaCursosPorIdEstudante(int idEstudante);
    }
}
