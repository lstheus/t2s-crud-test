using Microsoft.AspNetCore.Mvc;
using TesteBackEnd.Application.Interfaces;

namespace TesteBackEnd.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RelatorioController : Controller
    {
        private readonly IRelatorioService _relatorioService;
        public RelatorioController(IRelatorioService relatorioService)
        {
            this._relatorioService = relatorioService;
        }
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var relatorios = _relatorioService.Get();
                return Ok(relatorios);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
