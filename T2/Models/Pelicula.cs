using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace T2.Models
{
    public class Pelicula
    {
        public int Id_Pelicula { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Director { get; set; }
        public string Anio { get; set; }
        public string Imagen { get; set; }
        public bool Favorita { get; set; }
    }
}
