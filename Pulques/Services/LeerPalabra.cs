using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Pulques.Services
{
    public class LeerPalabra
    {
        public Array LeerPalabras()
        {
            Array maesData = null;
            var archivo = HttpContext.Current.Server.MapPath("~/App_Data/Palabras.txt");
            if (File.Exists(archivo))
            {
                maesData = File.ReadAllLines(archivo);
            }

            return maesData;
        }
    }
}