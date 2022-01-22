using Cursos.Service.Dtos;
using Cursos.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Cursos.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartaoController : Controller
    {
        private readonly ICartaoService _cartaoService;

        public CartaoController(ICartaoService cartaoService)
        {
            _cartaoService = cartaoService;
        }

        [Route("Cadastrar")]
        [HttpPost]
        public async Task<IActionResult> Inserir(DtoCartao cartao)
        {

            try
            {
                var retorno = await _cartaoService.Inserir(cartao);
                return Ok(retorno);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [Route("Atualizar")]
        [HttpPut]
        public async Task<IActionResult> Editar(DtoCartao cartao)
        {

            try
            {
                var retorno = await _cartaoService.Alterar(cartao);
                return Ok(retorno);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [Route("BuscaTodos")]
        //[Authorize]
        [HttpGet]
        public async Task<IActionResult> BuscaTodos()
        {
            try
            {
                var retorno = await _cartaoService.BuscarTodos();

                return Ok(retorno);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [Route("BuscarPorId")]
        //[Authorize]
        [HttpGet]
        public async Task<IActionResult> BuscarPorId(int idCurso)
        {
            try
            {

                var retorno = await _cartaoService.BuscarPorId(idCurso);

                return Ok(retorno);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [Route("Excluir")]
        //[Authorize]
        [HttpDelete]
        public async Task<IActionResult> Delete(int idCurso)
        {
            try
            {
                await _cartaoService.Excluir(idCurso);
                return Ok();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
