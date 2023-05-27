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
    public class TriangulosController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Triangulo triangulo)
        {
            String resultado;
            TriangulosService triangulosService = new TriangulosService();

            Punto p1 = new Punto(triangulo.punto1x, triangulo.punto1y);
            Punto p2 = new Punto(triangulo.punto2x, triangulo.punto2y);
            Punto p3 = new Punto(triangulo.punto3x, triangulo.punto3y);
            
            double dist1_2 = triangulosService.DistanceToPoints(p1, p2);
            double dist2_3 = triangulosService.DistanceToPoints(p2, p3);
            double dist3_1 = triangulosService.DistanceToPoints(p3, p1);
            const double TOLERANCIA = 0.01;

            if (Math.Abs(dist1_2 - dist2_3) < TOLERANCIA && Math.Abs(dist2_3 - dist3_1) < TOLERANCIA && Math.Abs(dist3_1 - dist1_2) < TOLERANCIA) {
                
                resultado = "Triangulo equilatero";

            } else if(dist1_2 == dist2_3 || dist2_3 == dist3_1 || dist3_1 == dist1_2)
            {
                resultado = "Triangulo Isoceles";
            }else
            {
                resultado = "Triangulo escaleno";
            }
            var routeValues = new RouteValueDictionary
            {
                { "resultado", resultado },
                { "area" , triangulosService.GetTriangleArea(p1, p2, p3) }
            };
            return RedirectToAction("Resultado", "Triangulos", routeValues);
        }
        public ActionResult Resultado(String resultado, double area)
        {
            ViewBag.Resultado = resultado;
            ViewBag.Area = area;
            return View();
        }
    }
}