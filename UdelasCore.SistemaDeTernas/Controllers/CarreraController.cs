using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UdelasCore.Negocio.Servicios.HorariosDocencia;

namespace UdelasCore.SistemaDeTernas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarreraController : ControllerBase
    {
        readonly CarreraService _carreraService;

        public CarreraController(CarreraService carreraService)
        {
            _carreraService = carreraService;
        }

        [HttpGet]
        async public Task<IActionResult> Get([FromQuery] string search)
        {
            var carreras = await _carreraService.GetCarrerasAsync();

            if (carreras == null || !carreras.Any())
            {
                return NotFound(new { message = "No se encontraron carreras." });
            }

            return Ok(carreras.Where(c => c.Carrera.ToLower().Contains(search.ToLower()) || c.CodCarrera.ToString().ToLower().Contains(search)).ToList());
        }

        [HttpGet("{id}")]
        async public Task<IActionResult> GetById(int id)
        {
            var carrera = await _carreraService.GetCarrerasAsync();
            if (carrera == null || !carrera.Any(c => c.CodCarrera == id))
            {
                return NotFound(new { message = "Carrera no encontrada." });
            }
            return Ok(carrera.FirstOrDefault(c => c.CodCarrera == id));
        }
    }
}
