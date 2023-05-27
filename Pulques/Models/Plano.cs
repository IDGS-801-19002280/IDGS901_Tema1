using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pulques.Models
{
    public class Plano
    {
        public double x1;
        public double x2;
        public double y1;
        public double y2;

        public double distancia;

        public void respuesta()
        {
            this.distancia = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
        }
    }
}