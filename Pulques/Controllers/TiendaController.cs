using Pulques.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace Pulques.Controllers
{
    public class TiendaController : Controller
    {
        // GET: Tienda
        public ActionResult Index()
        {
            var persona = new Persona()
            {
                Nombre = "Mario",
                Edad = 23,
                Empleado = false,
                Nacimiento = new DateTime(2001, 11, 3)
            };

            ViewBag.Persona = persona;
            return View();
        }

        public ActionResult Registrar()
        {
            var persona = new Persona();

            return View(persona);
        }

        public ActionResult Registrar2()
        {
            var persona = new Persona();
            return View(persona);
        }
    }
}