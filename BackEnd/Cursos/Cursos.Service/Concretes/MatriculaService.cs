using Cursos.Core.Model;
using Cursos.Repository.Interfaces;
using Cursos.Repository.Repository;
using Cursos.Service.Dtos;
using Cursos.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cursos.Service.Concretes
{
    public class MatriculaService : IMatriculaService
    {
        private readonly IMatriculaRepository _matriculaRepository;

        public MatriculaService(IMatriculaRepository matriculaRepository)
        {
            _matriculaRepository = matriculaRepository;
        }

        public async Task<DtoMatricula> Alterar(DtoMatricula model)
        {
            var matricula = new Matricula(
                    model.Id,
                    model.CodigoCurso,
                    model.CodigoEstudante,
                    model.DataMatricula
                );

            await _matriculaRepository.UpdateAsync(matricula);

            return model;
        }

        public Task<DtoMatricula> BuscarPorId(int idMatricula)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<DtoMatricula>> BuscarTodos()
        {
            var matriculas = await _matriculaRepository.GetAllAsync();

            List<DtoMatricula> dtoMatriculas = new List<DtoMatricula>();

            foreach (var dtoMatricula in matriculas)
            {
                var matricula = new DtoMatricula(
                    dtoMatricula.Id,
                    dtoMatricula.CodigoCurso,
                    dtoMatricula.CodigoEstudante,
                    dtoMatricula.DataMatricula
                );

                dtoMatriculas.Add(matricula);
            }

            return dtoMatriculas;
        }

        public async Task<bool> Excluir(int idMatricula)
        {
            return await _matriculaRepository.RemoveAsync(idMatricula);
        }

        public async Task<DtoMatricula> Inserir(DtoMatricula model)
        {
            var matricula = new Matricula(
                    model.Id,
                    model.CodigoCurso,
                    model.CodigoEstudante,
                    model.DataMatricula
                );

            await _matriculaRepository.AddAsync(matricula);

            return model;
        }
    }
}
