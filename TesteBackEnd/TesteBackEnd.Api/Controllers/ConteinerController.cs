using Microsoft.AspNetCore.Mvc;
using TesteBackEnd.Application.Interfaces;
using TesteBackEnd.Application.Models;
using TesteBackEnd.Application.Services;

namespace TesteBackEnd.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ConteinerController : Controller
    {
        private readonly IConteinerService _conteinerService;
        public ConteinerController(IConteinerService conteinerService)
        {
            this._conteinerService = conteinerService;
        }
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var conteiners = _conteinerService.Get();
                return Ok(conteiners);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost()]
        public IActionResult Post(ConteinerInputModel conteiner)
        {
            try
            {
                _conteinerService.Post(conteiner);
                return CreatedAtAction("GetByCode", new { conteiner.Codigo }, conteiner);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("GetByCode/{codigo}")]
        public IActionResult GetByCode(string codigo)
        {
            try
            {
                var conteiner = _conteinerService.GetById(codigo);
                return Ok(conteiner);

            }
            catch (NullReferenceException ex)
            {
                return NotFound("Conteiner não encontrado" + ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut("Put/{codigo}")]
        public IActionResult Put(string codigo, ConteinerInputModel conteiner)
        {
            try
            {
                _conteinerService.Put(codigo, conteiner);
                return NoContent();

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete("Delete/{codigo}")]
        public IActionResult Post(string codigo)
        {
            try
            {
                _conteinerService.Delete(codigo);
                return Ok("Conteiner excluido com sucesso");

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
