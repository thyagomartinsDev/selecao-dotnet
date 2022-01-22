using Cursos.Core.Model;
using Cursos.Service.Dtos;
using Cursos.Service.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;
using Cursos.Repository.Interfaces;

namespace Cursos.Service.Concretes
{
    public class CursoService : ICursoService
    {
        private readonly ICursoRepository _cursoRepository;

        public CursoService(ICursoRepository cursoRepository)
        {
            _cursoRepository = cursoRepository;
        }
        public async Task<DtoCurso> Alterar(DtoCurso model)
        {
            var curso = new Curso(
                    model.Id,    
                    model.Descricao,
                    model.DuracaoCurso,
                    model.ValorCurso
                );

            await _cursoRepository.UpdateAsync(curso);

            return model;
        }

        public async Task<DtoCurso> BuscarPorId(int idCuso)
        {
            var cuso = await _cursoRepository.GetByIdAsync(idCuso);

            var dtoCuso = new DtoCurso(
                    cuso.Id,
                    cuso.Descricao,
                    cuso.DuracaoCurso,
                    cuso.ValorCurso
                );

            return dtoCuso;
        }

        public async Task<IEnumerable<DtoCurso>> BuscarTodos()
        {
            var cusos = await _cursoRepository.GetAllAsync();

            List<DtoCurso> dtoCursos = new List<DtoCurso>();

            foreach (var dtoCurso in cusos)
            {
                var curso = new DtoCurso(
                    dtoCurso.Id,
                    dtoCurso.Descricao,
                    dtoCurso.DuracaoCurso,
                    dtoCurso.ValorCurso
                );

                dtoCursos.Add(curso);
            }

            return dtoCursos;
        }

        public async Task<bool> Excluir(int idEstudante)
        {
            return await _cursoRepository.RemoveAsync(idEstudante);
        }

        public async Task<DtoCurso> Inserir(DtoCurso model)
        {
            var curso = new Curso
                (
                    model.Id,
                    model.Descricao,
                    model.DuracaoCurso,
                    model.ValorCurso
                );

            await _cursoRepository.AddAsync(curso);

            return model;
        }
    }
}
