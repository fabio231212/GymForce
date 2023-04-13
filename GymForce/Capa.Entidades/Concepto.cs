using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Entidades
{
   public class Concepto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int IdTipo { get; set; }
        public double Precio { get; set; }

        public TipoConcepto _TipoConcepto { get; set; }


    }
}
