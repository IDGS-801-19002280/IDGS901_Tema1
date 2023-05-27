using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pulques.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Grupo = "IDGS-901";
            ViewData["Materias"] = "Materiea";
            String nombre = "";

            if (TempData.ContainsKey("Nombre"))
            {
                nombre = TempData["Nombre"] as String;
            }

            ViewBag.Nombre = nombre;

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Suma()
        {
            ViewBag.Message = "Simon aqui suman";
            return View();
        }
    }
}