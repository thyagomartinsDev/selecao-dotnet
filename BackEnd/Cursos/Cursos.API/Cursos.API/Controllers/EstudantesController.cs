using Cursos.Service.Dtos;
using Cursos.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Cursos.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstudantesController : Controller
    {

        IEstudanteService _estudanteService;

        public EstudantesController(IEstudanteService estudanteService)
        {
            _estudanteService = estudanteService;
        }

        [Route("Cadastrar")]
        [HttpPost]
        public async Task<IActionResult> Inserir([FromBody] DtoEstudante dtoEstudante)
        {
            try
            {
                var retorno = await _estudanteService.Inserir(dtoEstudante);

                return Ok(retorno);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [Route("Atualizar")]
        [HttpPut]
        public async Task<IActionResult> Alterar([FromBody] DtoEstudante dtoEstudante)
        {
            try
            {
                var retorno = await _estudanteService.Alterar(dtoEstudante);

                return Ok(retorno);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [Route("BuscaTodos")]
        //[Authorize]
        [HttpGet]
        public async Task<IActionResult> BuscaTodos()
        {
            try
            {
                var retorno = await _estudanteService.BuscarTodos();

                return Ok(retorno);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [Route("BuscarPorId")]
        //[Authorize]
        [HttpGet]
        public async Task<IActionResult> BuscarPorId(int idEstudante)
        {
            try
            {

                var retorno = await _estudanteService.BuscarPorId(idEstudante);

                return Ok(retorno);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [Route("BuscarPorCPF")]
        //[Authorize]
        [HttpGet]
        public async Task<IActionResult> BuscarPorCPF(string cpfEstudante)
        {
            try
            {

                var retorno = await _estudanteService.BuscarPorCPF(cpfEstudante);

                return Ok(retorno);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [Route("Excluir")]
        //[Authorize]
        [HttpDelete]
        public async Task<IActionResult> Deletar(int idEstudante)
        {
            try
            {

                var retorno = await _estudanteService.Excluir(idEstudante);
                return Ok(retorno);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
