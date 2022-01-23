using Cursos.Service.Dtos;
using Cursos.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Cursos.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendaController : Controller
    {

        private readonly IVendaService _vendaService;
        public VendaController(IVendaService vendaService)
        {
            _vendaService = vendaService;
        }

        [Route("Cadastrar")]
        [HttpPost]
        public async Task<IActionResult> Inserir(DtoVenda venda)
        {

            try
            {
                var retorno = await _vendaService.Inserir(venda);
                return Ok(retorno);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [Route("Atualizar")]
        [HttpPut]
        public async Task<IActionResult> Editar(DtoVenda venda)
        {

            try
            {
                var retorno = await _vendaService.Alterar(venda);
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
                var retorno = await _vendaService.BuscarTodos();

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
        public async Task<IActionResult> BuscarPorId(int idVenda)
        {
            try
            {

                var retorno = await _vendaService.BuscarPorId(idVenda);

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
        public async Task<IActionResult> Delete(int idVenda)
        {
            try
            {
                await _vendaService.Excluir(idVenda);
                return Ok();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
