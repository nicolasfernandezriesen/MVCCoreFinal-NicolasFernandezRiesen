using Microsoft.AspNetCore.Mvc;
using System;

namespace SistemaWebEmpleado.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Fecha = DateTime.Today.ToString();
            ViewBag.Message = "Binvenidos al sitio web!";
            return View();
        }
    }
}
