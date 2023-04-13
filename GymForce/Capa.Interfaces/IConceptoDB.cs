using Capa.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Interfaces
{
    public interface IConceptoDB
    {

        void Insertar(Concepto concepto);
        void Actualizar(Concepto concepto);
        void Eliminar(int id);
        List<Concepto> SeleccionarTodas();
        Concepto SeleccionarPorId(int id);
        List<Concepto> GetConceptoByFiltro(string filtro);

        void UpdateConceptoMulta(int Id, double precio);
    }
}
