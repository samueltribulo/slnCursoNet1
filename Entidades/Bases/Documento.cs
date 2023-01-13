using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Bases
{
    public abstract class Documento
    {

        public string Numero { get; set; }

        public DateTime Date { get; set; }

        public string Cliente { get; set; }

        public string Direccion { get; set; }

        public string CondicionIva { get; set;}

        public string CondicionVenta { get; set;}

        public string Detalle { get; set; }

        public string Total { get; set; }

    }
}
