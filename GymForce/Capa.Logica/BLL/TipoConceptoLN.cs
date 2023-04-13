using Capa.Datos;
using Capa.Entidades;
using Capa.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Logica.BLL
{
    public class TipoConceptoLN : ITipoConceptoLN
    {

        /// <summary>
        /// Método que obtiene tipo concepto por Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public TipoConcepto ObtenerPorId(int id)
        {
            ITipoConceptoDB datos = new TipoConceptoDB();
            return datos.obtenerTipoConceptoPorId(id);
        }

        /// <summary>
        /// Método que obtiene todos los tipos de conceptos
        /// </summary>
        /// <returns></returns>
        public List<TipoConcepto> ObtenerTiposConcepto()
        {
            ITipoConceptoDB datos = new TipoConceptoDB();
            return datos.obtenerTipoConceptos();
        }
    }
}
