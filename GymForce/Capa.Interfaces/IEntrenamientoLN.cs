using Capa.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Interfaces
{
    public interface IEntrenamientoLN
    {
        void Guardar(Entrenamiento entrenamiento);
        void Actualizar(Entrenamiento entrenamiento);
        void Eliminar(int id);
        Entrenamiento ObtenerEntrenamientosPorId(int id);
        List<Entrenamiento> ObtenerEntrenamientos();
    }
}
