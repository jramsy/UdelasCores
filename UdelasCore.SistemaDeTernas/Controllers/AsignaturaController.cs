using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UdelasCore.Negocio.Servicios.HorariosDocencia;

namespace UdelasCore.SistemaDeTernas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AsignaturaController : ControllerBase
    {
        private readonly MateriasPorCarreraService _asignaturaService;

        public AsignaturaController(MateriasPorCarreraService asignaturaService)
        {
            _asignaturaService = asignaturaService;
        }

        [HttpGet]
        async public Task<IActionResult> Get([FromQuery] string search, [FromQuery] int codCarrera)
        {
            var asignaturas = await _asignaturaService.GetMateriasPorCarreraAsync();

            var resultado = asignaturas
                .Where(a =>
                    (string.IsNullOrEmpty(search) || a.Descripcion.ToLower().Contains(search.ToLower()) && a.CodCarrera == codCarrera)
                ).ToList();

            return Ok(resultado);
        }
    }
}
