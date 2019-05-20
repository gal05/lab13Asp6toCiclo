using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace demo03.Models
{
    public class Alumno
    {
        public int Id { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Dni { get; set; }
    }
    //scalfolding para el crud
}