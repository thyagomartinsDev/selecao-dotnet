using Cursos.Core.Model;
using Cursos.Repository.Interfaces;
using Cursos.Service.Dtos;
using Cursos.Service.Interfaces;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cursos.Service
{
    public class EstudanteService : IEstudanteService
    {

        private readonly IEstudanteRepository _estudanteRepository;

        public EstudanteService(IEstudanteRepository estudanteRepository)
        {
            _estudanteRepository = estudanteRepository;
        }

        public async Task<DtoEstudante> Alterar(DtoEstudante model)
        {
            var estudante = new Estudante
                (
                    model.Id,
                    model.Nome,
                    model.Cpf,
                    model.Endereco,
                    model.Email
                );

            await _estudanteRepository.UpdateAsync(estudante);

            return model;
        }

        public async Task<DtoEstudante> BuscarPorId(int idEstudante)
        {
            var estudante = await _estudanteRepository.GetByIdAsync(idEstudante);

            var dtoEstudante = new DtoEstudante(
                estudante.Id,
                estudante.Nome,
                estudante.Cpf,
                estudante.Email,
                estudante.Endereco
                );

            return dtoEstudante;
        }

        public async Task<DtoEstudante> BuscarPorCPF(string cpfEstudante)
        {
            var estudantes = await _estudanteRepository.GetAllAsync();

            var estudante = estudantes.FirstOrDefault(e => e.Cpf == cpfEstudante);

            var dtoEstudante = new DtoEstudante(
                estudante.Id,
                estudante.Nome,
                estudante.Cpf,
                estudante.Email,
                estudante.Endereco
                );

            return dtoEstudante;
        }

        public async Task<IEnumerable<DtoEstudante>> BuscarTodos()
        {
            var estudantes = await _estudanteRepository.GetAllAsync();

            List<DtoEstudante> dtoEstudantes = new List<DtoEstudante>();

            foreach(var estudante in estudantes)
            {
                var dtoEstudante = new DtoEstudante(
                estudante.Id,
                estudante.Nome,
                estudante.Cpf,
                estudante.Email,
                estudante.Endereco
                );

                dtoEstudantes.Add(dtoEstudante);
            }

            return dtoEstudantes;
        }

        public async Task<bool> Excluir(int idEstudante)
        {
            return await _estudanteRepository.RemoveAsync(idEstudante);
        }

        public async Task<DtoEstudante> Inserir(DtoEstudante model)
        {
            var estudante = new Estudante
                (
                    model.Id,
                    model.Nome,
                    model.Cpf,
                    model.Endereco,
                    model.Email
                );

            var retorno = await _estudanteRepository.AddAsync(estudante);

            model = new DtoEstudante
                (
                    retorno.Id,
                    retorno.Nome,
                    retorno.Cpf,
                    retorno.Email,
                    retorno.Endereco
                );

            return model;
        }
    }
}
