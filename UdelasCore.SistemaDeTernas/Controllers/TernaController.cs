using Microsoft.AspNetCore.Mvc;

namespace SistemaTernas.Controllers
{
    public class TernaController : Controller
    {
        public IActionResult Index()
        {
            return View("Revision");
        }
    }
}
