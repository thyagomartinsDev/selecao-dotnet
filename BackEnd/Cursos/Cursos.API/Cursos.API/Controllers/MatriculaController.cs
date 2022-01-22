using Cursos.Service.Dtos;
using Cursos.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Cursos.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MatriculaController : Controller
    {

        private readonly IMatriculaService _matriculaService;

        public MatriculaController(IMatriculaService matriculaService)
        {
            _matriculaService = matriculaService;
        }

        [Route("Cadastrar")]
        [HttpPost]
        public async Task<IActionResult> Inserir(DtoMatricula matricula)
        {

            try
            {
                var retorno = await _matriculaService.Inserir(matricula);
                return Ok(retorno);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [Route("Atualizar")]
        [HttpPut]
        public async Task<IActionResult> Editar(DtoMatricula matricula)
        {

            try
            {
                var retorno = await _matriculaService.Alterar(matricula);
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
                var retorno = await _matriculaService.BuscarTodos();

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
        public async Task<IActionResult> BuscarPorId(int idMatricula)
        {
            try
            {

                var retorno = await _matriculaService.BuscarPorId(idMatricula);

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
        public async Task<IActionResult> Delete(int idMatricula)
        {
            try
            {
                await _matriculaService.Excluir(idMatricula);
                return Ok();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
