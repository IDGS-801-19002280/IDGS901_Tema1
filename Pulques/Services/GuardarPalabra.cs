using Pulques.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Pulques.Services
{
    public class GuardarPalabra
    {
        public void GuardarPalabraIdiomas(Palabra palabra)
        {
            var es = palabra.espaniol;
            var ing = palabra.ingles;
            var dict = es.ToLower() + "," + ing.ToLower() + Environment.NewLine;

            var archivo = HttpContext.Current.Server.MapPath("~/App_Data/Palabras.txt");
            File.AppendAllText(archivo, dict);
        }
    }
}