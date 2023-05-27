using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pulques.Controllers
{
    public class TemperaturaController : Controller
    {
        // GET: Temperatura
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Resultado(double Temperatura, int Seleccion)
        {
            double resultado;
            if (Seleccion == 1)
            {
                resultado = (Temperatura - 32) * (5.0 / 9.0);
            }
            else
            {
                resultado = (Temperatura * (9.0 / 5.0)) + 32;
            }

            ViewBag.Resultado = resultado;

            return View();
        }
    }
}