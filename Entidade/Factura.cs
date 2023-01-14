using Entidades.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Factura:Documento
    {
        public Factura(string Numero, DateTime Date, string Cliente, string Direccion, string CondicionIva, string CondicionVenta, string Detalle, string Total ,string Tipo) : base(Numero, Date, Cliente, Direccion, CondicionIva, CondicionVenta, Detalle, Total)
        {

            this.Tipo = Tipo;

        }
        public string Tipo { get; set; }

    }
}
