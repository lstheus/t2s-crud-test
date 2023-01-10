using Microsoft.AspNetCore.Mvc;
using TesteBackEnd.Application.Interfaces;
using TesteBackEnd.Application.Models;
using TesteBackEnd.Application.Services;

namespace TesteBackEnd.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MovimentacaoController : Controller
    {
        private readonly IMovimentacaoService _movimentacaoService;
        public MovimentacaoController(IMovimentacaoService movimentacaoService)
        {
            this._movimentacaoService = movimentacaoService;
        }
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var movimentacaos = _movimentacaoService.Get();
                return Ok(movimentacaos);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("GetById/{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                var movimentacao = _movimentacaoService.GetById(id);
                return Ok(movimentacao);

            }
            catch (NullReferenceException ex)
            {
                return NotFound("Movimentação não encontrada" + ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost()]
        public IActionResult Post(MovimentacaoInputModel movimentacao)
        {
            try
            {
                _movimentacaoService.Post(movimentacao);
                return CreatedAtAction("GetById", new { movimentacao.Id }, movimentacao);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut("Put/{id}")]
        public IActionResult Put(int id, MovimentacaoInputModel movimentacao)
        {
            try
            {
                _movimentacaoService.Put(id, movimentacao);
                return NoContent();

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete("Delete/{id}")]
        public IActionResult Post(int id)
        {
            try
            {
                _movimentacaoService.Delete(id);
                return Ok("Movimentação excluida com sucesso");

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
