using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pulques.Models
{
    public class Punto
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Punto(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
}

//Math.Sqrt(Math.Pow(punto.X - X, 2) + Math.Pow(punto.Y - Y, 2));