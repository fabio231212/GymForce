using Capa.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Interfaces
{
    public interface ITipoConceptoLN
    {
        TipoConcepto ObtenerPorId(int id);
        List<TipoConcepto> ObtenerTiposConcepto();

    }
}
