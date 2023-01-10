using Microsoft.AspNetCore.Mvc;
using TesteBackEnd.Application.Interfaces;
using TesteBackEnd.Application.Models;

namespace TesteBackEnd.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClienteController : Controller
    {
        private readonly IClienteService _clienteService;
        public ClienteController(IClienteService clienteService)
        {
            this._clienteService = clienteService;
        }
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var clientes = _clienteService.Get();
                return Ok(clientes);

            }catch(Exception ex)
            {
                return BadRequest(ex.Message);  
            }
        }
        [HttpGet("GetById/{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                var cliente = _clienteService.GetById(id);
                return Ok(cliente);

            }
            catch (NullReferenceException ex)
            {
                return NotFound("Cliente não encontrado" + ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost()]
        public IActionResult Post(ClienteInputModel cliente)
        {
            try
            {
                _clienteService.Post(cliente);
                return CreatedAtAction("GetById",new {cliente.Id},cliente);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
