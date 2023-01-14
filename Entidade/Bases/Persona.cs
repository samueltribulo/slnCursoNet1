using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Bases
{
    public abstract class Persona
    {
        public string Nombre { get; set; }

        public string Email { get; set; }   

        public string Telefono { get; set; }

        public string Direccion { get; set; }


    }
}
