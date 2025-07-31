using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Udelascore.Negocio.Servicios.SistemaTernas;

namespace SistemaTernas.Controllers
{
    [Route("profesor")]
    public class ProfesorController : Controller
    {
        private ProfesorService _profesorService;

        public ProfesorController(ProfesorService profesorService)
        {
            _profesorService = profesorService;
        }

        public IActionResult Index()
        {
            var profesores = _profesorService.GetAllProfesoresAsync().Result;
            return View();
        }

        [HttpGet("lista")]
        public async Task<IActionResult> GetProfesores(string cedula)
        {
            var profesores = await _profesorService.GetAllProfesoresAsync();
            if (profesores == null)
            {
                return NotFound();
            }
            return Ok(profesores);
        }

    }
}
