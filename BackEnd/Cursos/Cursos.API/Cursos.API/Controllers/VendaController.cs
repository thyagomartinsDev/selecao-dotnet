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

        private readonly IVedaService _vedaService;
        public VendaController(IVedaService vedaService)
        {
            _vedaService = vedaService;
        }

        [Route("Cadastrar")]
        [HttpPost]
        public async Task<IActionResult> Inserir(DtoVenda matricula)
        {

            try
            {
                var retorno = await _vedaService.Inserir(matricula);
                return Ok(retorno);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [Route("Atualizar")]
        [HttpPut]
        public async Task<IActionResult> Editar(DtoVenda matricula)
        {

            try
            {
                var retorno = await _vedaService.Alterar(matricula);
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
                var retorno = await _vedaService.BuscarTodos();

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

                var retorno = await _vedaService.BuscarPorId(idVenda);

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
                await _vedaService.Excluir(idVenda);
                return Ok();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
