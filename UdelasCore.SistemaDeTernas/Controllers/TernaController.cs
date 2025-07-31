using Microsoft.AspNetCore.Mvc;
using UdelasCore.Negocio.Servicios.SistemaTernas;
using UdelasCore.Negocio.Modelos.RecursosHumanos.DTOs;
using UdelasCore.Negocio.Modelos.RecursosHumanos.DTOs.TernaDetalles;
using UdelasCore.Negocio.Modelos.RecursosHumanos.DTOs.Ternas;

namespace SistemaTernas.Controllers
{
    public class TernaController : Controller
    {
        private readonly TernaService _ternaService;

        public TernaController(TernaService ternaService)
        {
            _ternaService = ternaService;
        }

        public async Task<IActionResult> Index()
        {
            List<ObtainTernasDTO> ternas = await _ternaService.GetAllTernasAsync();

            ViewBag.Ternas = ternas;

            return View("Revision");
        }

        public async Task<IActionResult> Historial()
        {
            List<ObtainTernasDTO> ternas = await _ternaService.GetAllTernasAsync();

            var ternasAprobadas = ternas.Where(t => t.IdEstado == 3).ToList();

            ViewBag.Ternas = ternasAprobadas;

            return View("HistorialAprobadas");
        }


        [HttpGet("api/terna/{id}/detalles")]
        public async Task<IActionResult> ObtenerTernasDetalle(int id)
        {
            var detalles = await _ternaService.GetTernasDetalleByIdAsync(id);

            if (detalles == null || !detalles.Any())
                return NotFound(new { message = $"No se encontraron detalles para la terna con ID {id}." });

            return Ok(detalles);
        }

        [HttpPut("api/terna/{id}/estado")]
        public async Task<IActionResult> SeleccionarTernaDetalle(int id, [FromBody] ActualizarTernaEstadoDTO detalle)
        {
            if (id <= 0 || detalle == null || detalle.IdTerna != id)
            {
                return BadRequest(new { message = "ID inválido o datos de detalle incorrectos." });
            }
            // Aquí se llamaría al servicio para actualizar el detalle
            await _ternaService.UpdateTernaEstado(detalle);
            return Ok(new { message = "Detalle de terna actualizado correctamente." });

        }
    }
}
