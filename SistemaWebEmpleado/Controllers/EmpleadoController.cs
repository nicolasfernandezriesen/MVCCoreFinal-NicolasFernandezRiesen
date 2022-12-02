using Microsoft.AspNetCore.Mvc;
using SistemaWebEmpleado.Data;
using SistemaWebEmpleado.Models;
using System.Collections.Generic;
using System.Linq;
using System;

namespace SistemaWebEmpleado.Controllers
{
    public class EmpleadoController : Controller
    {
        private readonly DBEmpleadosContext context;

        public EmpleadoController(DBEmpleadosContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            return View(context.Empleados.ToList());
        }

        public IActionResult Create()
        {
            Empleado empleado = new Empleado();
            
            return View(empleado);
        }

        [HttpPost]
        public IActionResult Create(Empleado empleado)
        {
            if (ModelState.IsValid)
            {
                context.Add(empleado);
                context.SaveChanges();

                return RedirectToAction("Index");
            }
            else
            {
                return View("Create", empleado);
            }
        }

       
        [Route("Empleado/ListarEmpleadoTitulo/{titulo}")]
        public IActionResult ListarEmpleadoTitulo(string titulo) 
        {
            List<Empleado> list = (from e in context.Empleados
                                   where e.Titulo == titulo
                                   select e).ToList();

            return View("Index", list);
        }

        public IActionResult Details(int id)
        {
            Empleado empleado = context.Empleados.Find(id);

            if (empleado == null)
            {
                return NotFound();  
            }
            else
            {
                return View("Details", empleado);
            }
        }

        public IActionResult Delete(int id)
        {
            Empleado empleado = context.Empleados.Find(id);

            if (empleado == null)
            {
                return NotFound();
            }
            else
            {
                return View("Delete", empleado);
            }
        }

        [HttpPost]
        public IActionResult DeleteConfirmed(int id)
        {
            Empleado empleado = context.Empleados.Find(id);

            if (empleado != null)
            {
                context.Remove(empleado);
                context.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}
