using Microsoft.AspNetCore.Mvc;
using UdelasCore.Negocio.Modelos.RecursosHumanos.DTOs;
using UdelasCore.Negocio.Modelos.RecursosHumanos.DTOs.Ternas;
using UdelasCore.Negocio.Servicios.BancoDeDatos;
using Udelascore.Negocio.Models.BancoDeDatos;
using UdelasCore.Negocio.Servicios.RecursosHumanos;
using UdelasCore.Negocio.DTOs;

namespace SistemaTernas.Controllers
{
    public class TernaController : Controller
    {
        private readonly TernaService _ternaService;
        private readonly ExtensionService _extensionService;

        public TernaController(TernaService ternaService, ExtensionService extensionService)
        {
            _ternaService = ternaService;
            _extensionService = extensionService;
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

        public async Task<IActionResult> RegistroTerna()
        {
            List<ObtainTernasDTO> ternas = await _ternaService.GetAllTernasAsync();

            List<Extensiones> extensiones = await _extensionService.GetExtensionsAsync();

            ViewBag.Ternas = ternas;
            ViewBag.Extensiones = extensiones;

            return View("RegistroTerna");
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

        [HttpPost("api/terna")]
        public async Task<IActionResult> CrearEditarTerna([FromBody] TernaRequestDto request)
        {
            if (request.Terna == null && request.Detalle == null)
            {
                return BadRequest(new { message = "Debe enviar al menos la terna o el detalle." });
            }

            try
            {
                var terna = await _ternaService.CreateOrUpdateTernaAsync(request.Terna, request.Detalle);
                return Ok(new { message = "Operación completada con éxito.", terna });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Error interno", error = ex.Message });
            }
        }

        [HttpDelete("api/terna/{id}")]
        public async Task<IActionResult> DeleteTerna(int id)
        {
            var eliminado = await _ternaService.DeleteTernaAsync(id, 1);

            if (!eliminado)
            {
                return NotFound(new { mensaje = $"No se encontró ninguna terna con ID {id} para eliminar." });
            }

            return Ok(new { mensaje = "Terna eliminada correctamente." });
        }

        [HttpDelete("api/terna-detalle/{id}")]
        public async Task<IActionResult> DeleteTernaDetalle(int id)
        {
            var eliminado = await _ternaService.DeleteTernaDetalleAsync(id, 1);

            if (!eliminado)
            {
                return NotFound(new { mensaje = $"No se encontró ninguna terna con ID {id} para eliminar." });
            }

            return Ok(new { mensaje = "Terna eliminada correctamente." });
        }

    }
}
