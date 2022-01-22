using Cursos.Core.Model;
using Cursos.Repository.Interfaces;
using Cursos.Service.Dtos;
using Cursos.Service.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cursos.Service.Concretes
{
    public class CartaoService : ICartaoService
    {

        private readonly ICartaoRepository _cartaoRepository;

        public CartaoService(ICartaoRepository cartaoRepository)
        {
            _cartaoRepository = cartaoRepository;
        }

        public async Task<DtoCartao> Alterar(DtoCartao model)
        {
            var cartao = new Cartao(
                    model.Id,
                    model.NumeroCartao,
                    model.CodigoCartao,
                    model.ValidadeCartao,
                    model.NomeTitular,
                    model.BandeiraCartao,
                    model.IdEstudante
                );

            await _cartaoRepository.UpdateAsync(cartao);

            return model;
        }

        public async Task<DtoCartao> BuscarPorId(int idCartao)
        {
            var cartao = await _cartaoRepository.GetByIdAsync(idCartao);

            var dtoCartao = new DtoCartao(
                    cartao.Id,
                    cartao.NumeroCartao,
                    cartao.CodigoCartao,
                    cartao.ValidadeCartao,
                    cartao.NomeTitular,
                    cartao.BandeiraCartao,
                    cartao.IdEstudante
                );

            return dtoCartao;
        }

        public async Task<IEnumerable<DtoCartao>> BuscarTodos()
        {
            var cartoes = await _cartaoRepository.GetAllAsync();

            List<DtoCartao> dtoCatoes = new List<DtoCartao>();

            foreach (var dtoCartao in cartoes)
            {
                var cartao = new DtoCartao(
                    dtoCartao.Id,
                    dtoCartao.NumeroCartao,
                    dtoCartao.CodigoCartao,
                    dtoCartao.ValidadeCartao,
                    dtoCartao.NomeTitular,
                    dtoCartao.BandeiraCartao,
                    dtoCartao.IdEstudante
                );

                dtoCatoes.Add(cartao);
            }

            return dtoCatoes;
        }

        public async Task<bool> Excluir(int idCartao)
        {
            return await _cartaoRepository.RemoveAsync(idCartao);
        }

        public async Task<DtoCartao> Inserir(DtoCartao model)
        {
            var cartao = new Cartao(
                    model.Id,
                    model.NumeroCartao,
                    model.CodigoCartao,
                    model.ValidadeCartao,
                    model.NomeTitular,
                    model.BandeiraCartao,
                    model.IdEstudante
                );

            await _cartaoRepository.AddAsync(cartao);

            return model;
        }
    }
}
