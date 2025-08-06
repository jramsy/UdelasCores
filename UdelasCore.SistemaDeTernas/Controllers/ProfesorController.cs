using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UdelasCore.Negocio.Servicios.BancoDeDatos;

namespace UdelasCore.SistemaDeTernas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfesorController : ControllerBase
    {
        private readonly ProfesorService _profesorService;

        public ProfesorController(ProfesorService profesorService)
        {
            _profesorService = profesorService;
        }

        [HttpGet]
        async public Task<IActionResult> GetProfesorByCedula([FromQuery] string cedula)
        {
            var profesor = await _profesorService.GetProfesorByCedulaAsync(cedula);
            if (profesor == null)
            {
                return NotFound();
            }
            return Ok(profesor);
        }
    }
}
