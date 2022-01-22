using Cursos.Core.Model;
using Cursos.Repository.Interfaces;
using Cursos.Service.Dtos;
using Cursos.Service.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cursos.Service.Concretes
{
    public class VendaService : IVedaService
    {

        private readonly IVendaRepository _vendaRepository;

        public VendaService(IVendaRepository vendaRepository)
        {
            _vendaRepository = vendaRepository;
        }
        public async Task<DtoVenda> Alterar(DtoVenda model)
        {
            var venda = new Venda(
                    model.Id,
                    model.CodigoCartao,
                    model.CodigoEstudante,
                    model.FormaPagamento,
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
                    venda.CodigoCartao,
                    venda.CodigoEstudante,
                    venda.FormaPagamento,
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
                    dtoVenda.CodigoCartao,
                    dtoVenda.CodigoEstudante,
                    dtoVenda.FormaPagamento,
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
                    model.CodigoCartao,
                    model.CodigoEstudante,
                    model.FormaPagamento,
                    model.ValorTotal
                );

            await _vendaRepository.AddAsync(venda);

            return model; ;
        }
    }
}
