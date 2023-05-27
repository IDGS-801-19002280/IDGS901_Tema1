using Pulques.Models;
using Pulques.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pulques.Controllers
{
    public class ArchivosController : Controller
    {
        // GET: Archivos
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GuardarArchivo()
        {
            return View();
        }
        [HttpPost]
        public ActionResult GuardarArchivo(Maestros maestros)
        {
            GuardarServices servicio = new GuardarServices();
            servicio.GuardarArchivo(maestros);
            return View();
        }

        public ActionResult LeerDatos()
        {
            var servicio = new LeerServices();
            ViewBag.Archivos = servicio.LeerArchivo();
            return View();
        }
    }
}