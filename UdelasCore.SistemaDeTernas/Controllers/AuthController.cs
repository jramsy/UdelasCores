﻿using Microsoft.AspNetCore.Mvc;

namespace UdelasCore.SistemaDeTernas.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Registro()
        {
            return View();
        }
    }
}
