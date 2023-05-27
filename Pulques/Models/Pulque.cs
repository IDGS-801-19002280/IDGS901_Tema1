using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pulques.Models
{
    public class Pulque
    {
        public string producto { get; set; }
        public int litros { get; set; }
        public DateTime produccion { get; set; }
        public string descripcion { get; set; }
    }
}