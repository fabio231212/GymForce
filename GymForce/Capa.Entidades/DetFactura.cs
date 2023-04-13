using Capa.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa.Entidades
{
    public class DetFactura
    {
        public int IdFactura { set; get; }
        public int IdConcepto { set; get; }


        public double Impuesto { set; get; }
        public int Secuencia { get; set; }
        public Concepto _Concepto { get; set; }


        public double GetImpuesto()
        {
            return _Concepto.Precio*Impuesto;
        }


    }
}
