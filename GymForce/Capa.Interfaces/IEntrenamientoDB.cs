using Capa.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Interfaces
{
    public interface IEntrenamientoDB
    {
        void Insertar(Entrenamiento entrenamiento);
        void Actualizar(Entrenamiento entrenamiento);
        void Eliminar(int id);
        List<Entrenamiento> SeleccionarTodas();
        Entrenamiento SeleccionarPorId(int id);

    }
}
