using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Bases
{
    public abstract class Documento
    {
        public Documento(string Numero, DateTime Date, string Cliente, string Direccion, string CondicionIva, string CondicionVenta, string Detalle, string Total) { 
        
            this.Numero = Numero;
            this.Date = Date;
            this.Cliente = Cliente;
            this.Direccion= Direccion;
            this.CondicionIva= CondicionIva;
            this.CondicionVenta= CondicionVenta;
            this.Detalle= Detalle;
            this.Total = Total;

        }

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
