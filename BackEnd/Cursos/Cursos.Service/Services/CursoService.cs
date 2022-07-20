using Cursos.Domain.Model;
using Cursos.Service.Dtos;
using Cursos.Service.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;
using Cursos.Repository.Interfaces;
using System.Linq;

namespace Cursos.Service.Services
{
    public class CursoService : ICursoService
    {
        private readonly ICursoRepository _cursoRepository;
        private readonly IEstudanteService _estudanteService;
        private readonly IMatriculaRepository _matriculaRepository;

        public CursoService(ICursoRepository cursoRepository,
                            IEstudanteService estudanteService,
                            IMatriculaRepository matriculaRepository)
        {
            _cursoRepository = cursoRepository;
            _estudanteService = estudanteService;
            _matriculaRepository = matriculaRepository;
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

        public async Task<DtoCurso> BuscarPorId(int idCurso)
        {
            var cuso = await _cursoRepository.GetByIdAsync(idCurso);

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

        public async Task<IEnumerable<DtoCurso>> BuscaCursosPorIdEstudante(int idEstudante)
        {
            var matriculas = await _matriculaRepository.GetAllAsync();
            var cursos = await _cursoRepository.GetAllAsync();

            var resultado = from curso in cursos
                            join matricula in matriculas
                            on curso.Id equals matricula.CodigoCurso
                            where matricula.CodigoEstudante == idEstudante
                            select new DtoCurso(
                                curso.Id,
                                curso.Descricao,
                                curso.DuracaoCurso,
                                curso.ValorCurso
                                );
            return resultado;
        }
    }
}
