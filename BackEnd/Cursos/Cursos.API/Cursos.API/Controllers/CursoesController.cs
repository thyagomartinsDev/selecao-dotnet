using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Cursos.Service.Interfaces;
using Cursos.Service.Dtos;

namespace Cursos.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CursoesController : Controller
    {
        private readonly ICursoService _cusoService;

        public CursoesController(ICursoService cusoService)
        {
            _cusoService = cusoService;
        }

        [Route("Cadastrar")]
        [HttpPost]
        public async Task<IActionResult> Inserir(DtoCurso curso)
        {

            try
            {
                await _cusoService.Inserir(curso);
                return Ok(curso);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [Route("Atualizar")]
        [HttpPut]
        public async Task<IActionResult> Editar(DtoCurso curso)
        {

            try
            {
                await _cusoService.Alterar(curso);
                return Ok();
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
                var retorno = await _cusoService.BuscarTodos();

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

                var retorno = await _cusoService.BuscarPorId(idCurso);

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
                await _cusoService.Excluir(idCurso);
                return Ok();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
