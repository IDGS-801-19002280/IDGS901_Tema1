using Pulques.Models;
using Pulques.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Pulques.Controllers
{
    public class ArchivoController : Controller
    {
        // GET: Archivo
        public ActionResult Index()
        {
            LeerPalabra leerPalabra = new LeerPalabra();
            ViewBag.Palabras = leerPalabra.LeerPalabras();
            return View();
        }

        [HttpPost]
        public RedirectToRouteResult Index(Palabra palabra)
        {
            Dictionary<String, String> palabras = new Dictionary<string, string>();
            LeerPalabra leerPalabra = new LeerPalabra();
            var palabaras = leerPalabra.LeerPalabras();

            foreach (String pal in palabaras)
            {
                var spleet = pal.Split(',');
                palabras.Add(spleet[0], spleet[1]);
            }

            if (!palabras.ContainsKey(palabra.espaniol))
            {
                GuardarPalabra guardarPalabra = new GuardarPalabra();
                guardarPalabra.GuardarPalabraIdiomas(palabra);
            }
            return RedirectToAction("Index", "Archivo");
        }

        public ActionResult Traductor(String palabra, String traduccion)
        {
            ViewBag.Palabra = palabra;
            ViewBag.Traduccion = traduccion;
            return View();
        }

        [HttpPost]
        public ActionResult Traducir(String palabra, int seleccion)
        {
            Dictionary<String, String> palabras = new Dictionary<string, string>();
            LeerPalabra leerPalabra = new LeerPalabra();
            var palabaras = leerPalabra.LeerPalabras();

            foreach (String pal in palabaras)
            {
                var spleet = pal.Split(',');
                if (seleccion == 1)
                {
                    palabras.Add(spleet[1], spleet[0]);
                }
                else
                {
                    palabras.Add(spleet[0], spleet[1]);
                }
            }

            String traudccion = "";
            if (palabras.ContainsKey(palabra.ToLower())) {
                traudccion += palabras[palabra.ToLower()];
            }
            else
            {
                traudccion += "Esa palabra no existe";
            }

            var routeValues = new RouteValueDictionary
            {
                { "palabra", palabra },
                { "traduccion", traudccion }
            };
            return RedirectToAction("Traductor", "Archivo", routeValues);
        }
    }
}