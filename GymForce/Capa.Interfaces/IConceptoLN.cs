using Capa.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Interfaces
{
    public interface IConceptoLN
    {
        void Guardar(Concepto concepto );
        void Actualizar(Concepto concepto);
        void Eliminar(int id);
        Concepto ObtenerConceptosPorId(int id);
        List<Concepto> ObtenerConceptos();

        List<Concepto> GetConceptoByFiltro(string filtro);

        void UpdateConceptoMulta(int Id, double precio);
    }
}
