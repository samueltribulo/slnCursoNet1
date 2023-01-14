using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        public Producto(string Nombre, string Descripcion, decimal PrecioCosto, double Margen, double IVA, string Proveedor, string Categoria, string SubCategoria) {

            this.Nombre = Nombre;
            this.Descripcion = Descripcion;
            this.PrecioCosto= PrecioCosto;
            this.Margen= Margen;
            this.IVA= IVA;
            this.Proveedor= Proveedor;
            this.Categoria= Categoria;
            this.SubCategoria= SubCategoria;

        }
        public string Nombre { get; set; }

        public string Descripcion { get; set;}

        public decimal PrecioCosto { get; set; }

        public double Margen { get; set; }

        public double IVA { get; set; }

        public decimal PrecioBruto
        {
            get
            {
                return Convert.ToDecimal(this.Margen) + this.PrecioCosto;
            }
        }

        public decimal PrecioVenta {
        
            get
            {
                return this.PrecioBruto * Convert.ToDecimal(1 + this.IVA);
            }
        }

        public string Proveedor { get; set; }

        public string Categoria { get; set; }

        public string SubCategoria { get; set; }


    }
}
