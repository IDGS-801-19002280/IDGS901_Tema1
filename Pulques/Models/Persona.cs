using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pulques.Models
{
    public class Persona
    {
        public String Nombre { get; set; }
        public int Edad {get; set; }
        public bool Empleado { get; set; } 
        public DateTime Nacimiento { get; set; }
    }
}