using Microsoft.AspNetCore.Mvc;
using UdelasCore.Negocio.Servicios.SistemaTernas;
using UdelasCore.Negocio.Modelos.RecursosHumanos.DTOs;

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
    }
}
