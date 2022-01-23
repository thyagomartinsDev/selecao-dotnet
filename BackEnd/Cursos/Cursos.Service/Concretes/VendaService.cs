using Cursos.Core.Model;
using Cursos.Repository.Interfaces;
using Cursos.Service.Dtos;
using Cursos.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cursos.Service.Concretes
{
    public class VendaService : IVendaService
    {

        private readonly IVendaRepository _vendaRepository;
        private readonly IMatriculaService _matriculaService;

        public VendaService(IVendaRepository vendaRepository,
                            IMatriculaService matriculaService)
        {
            _vendaRepository = vendaRepository;
            _matriculaService = matriculaService;
        }
        public async Task<DtoVenda> Alterar(DtoVenda model)
        {
            var venda = new Venda(
                    model.Id,
                    model.IdCurso,
                    model.IdCartao,
                    model.IdEstudante,
                    model.ValorTotal
                );

            await _vendaRepository.UpdateAsync(venda);            

            return model;
        }

        public async Task<DtoVenda> BuscarPorId(int idVenda)
        {

            var venda = await _vendaRepository.GetByIdAsync(idVenda);

            var dtoVenda = new DtoVenda(
                    venda.Id,
                    venda.IdCurso,
                    venda.IdCartao,
                    venda.IdEstudante,
                    venda.ValorTotal
                );            

            return dtoVenda;
        }

        public async Task<IEnumerable<DtoVenda>> BuscarTodos()
        {
            var vendas = await _vendaRepository.GetAllAsync();

            List<DtoVenda> dtoVendas = new List<DtoVenda>();

            foreach (var dtoVenda in vendas)
            {
                var venda = new DtoVenda(
                    dtoVenda.Id,
                    dtoVenda.IdCurso,
                    dtoVenda.IdCartao,
                    dtoVenda.IdEstudante,
                    dtoVenda.ValorTotal
                );

                dtoVendas.Add(venda);
            }

            return dtoVendas;
        }

        public async Task<bool> Excluir(int idVenda)
        {
            return await _vendaRepository.RemoveAsync(idVenda);
        }

        public async Task<DtoVenda> Inserir(DtoVenda model)
        {
            var venda = new Venda(
                    model.Id,
                    model.IdCurso,
                    model.IdCartao,
                    model.IdEstudante,
                    model.ValorTotal
                );

            await _vendaRepository.AddAsync(venda);

            var dataMatricula = DateTime.Now;
            var codigoCurso = venda.IdCurso;
            var codigoEstudante = venda.IdEstudante;

            var matricula = new DtoMatricula(
                    codigoCurso,
                    codigoEstudante,
                    dataMatricula
                );

            await _matriculaService.Inserir(matricula);

            return model; ;
        }
    }
}
