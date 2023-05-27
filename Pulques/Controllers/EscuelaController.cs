using Pulques.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pulques.Controllers
{
    public class EscuelaController : Controller
    {
        // GET: Escuela
        public ActionResult Index()
        {
            TempData["Nombre"] = "Ana";
            return View();
        }

        public ActionResult informasion()
        {

            return View();
        }

        public RedirectToRouteResult redirect()
        {
            return RedirectToAction("Index", "Home");
        }

        public RedirectToRouteResult Mereketengue()
        {
            TempData["Nombre"] = "Ana";
            return RedirectToAction("informasion");
        }
    }
}