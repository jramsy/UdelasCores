using Microsoft.AspNetCore.Mvc;
using UdelasCore.Negocio.Modelos.HorariosDocencia;
using UdelasCore.Negocio.Servicios.HorariosDocencia;

namespace UdelasCore.SistemaDeTernas.Controllers
{
    public class FacultadController : Controller
    {
        private readonly FacultadService _facultadService;

        public FacultadController(FacultadService facultadService)
        {
            _facultadService = facultadService;
        }

        [HttpGet("api/facultades")]
        public async Task<IActionResult> Index()
        {
            try
            {
                var facultades = await _facultadService.GetFacultadesAsync();

                if (facultades == null || !facultades.Any())
                {
                    return NotFound("No se encontraron facultades.");
                }

                return Ok(facultades);
            }
            catch (Exception ex)
            {

                return StatusCode(500, $"Ocurrió un error al procesar la solicitud: {ex.Message}");
            }
        }

    }
}
