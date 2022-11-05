using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Back_endBD.Models
{
    public class Maestros
    {
        public int id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Correo { get; set; }
        public string Puesto { get; set; }
        public string Horas { get; set; }
    }
}