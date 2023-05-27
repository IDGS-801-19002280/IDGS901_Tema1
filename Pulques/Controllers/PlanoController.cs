using Pulques.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pulques.Controllers
{
    public class PlanoController : Controller
    {
        // GET: Plano
        public ActionResult Index(String x1, String x2, String y1, String y2)
        { 
            Plano plano = new Plano();
            plano.x1 = Convert.ToInt16(x1);
            plano.x2 = Convert.ToInt16(x2);
            plano.y1 = Convert.ToInt16(y1);
            plano.y2 = Convert.ToInt16(y2);
            plano.respuesta();

            ViewBag.respuesta = plano.distancia;

            return View();
        }
    }
}