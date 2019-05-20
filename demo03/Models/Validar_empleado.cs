using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace demo03.Models
{
    public class Validar_empleado
    {
        [DisplayName("Codigo de empleado")]
        [Required(ErrorMessage ="Codio de empleado requerido")]
        public int Codigo { get; set; }

        [DisplayName("Apellido de empleado")]
        [StringLength(45,MinimumLength =3,ErrorMessage ="No mas de 45 caracteres")]
        public string Apellido { get; set; }

        [DisplayName("Nombre de empleado")]
        [StringLength(45, MinimumLength = 3, ErrorMessage = "No mas de 45 caracteres")]
        public string Nombre { get; set; }

        [DisplayName("Fecha de nacimiento")]
        [DataType(DataType.Date)]
        public Nullable<System.DateTime> Fnacimiento { get; set; }

        [DisplayName("Cargo")]
        public string Cargo { get; set; }

        [DisplayName("Sexo")]
        public string Sexo { get; set; }

        [DisplayName("Contrato")]
        public string Fcontrato { get; set; }

        [DisplayName("Numero telefonico")]
        public Nullable<int> Telefono { get; set; }

        [DisplayName("Correo electronico")]
        [EmailAddress(ErrorMessage ="Correo Electronico no valido1!")]
        public string Email { get; set; }

        [DisplayName("Numero De DNI")]
        public Nullable<int> Dni { get; set; }
    }
}