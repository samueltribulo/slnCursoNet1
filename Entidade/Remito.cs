using Entidades.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Remito:Documento
    {
        public Remito(string Numero, DateTime Date, string Cliente, string Direccion, string CondicionIva, string CondicionVenta, string Detalle, string Total, string FechaEntrega) : base(Numero, Date, Cliente, Direccion, CondicionIva, CondicionVenta, Detalle, Total)
        {

            this.FechaEntrega = FechaEntrega;

        }
        public string FechaEntrega { get; set; }


    }
}
