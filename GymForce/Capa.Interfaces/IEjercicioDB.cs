using Capa.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Interfaces
{
    public interface IEjercicioDB
    {
        void Insertar(Ejercicio ejercicio);
        void Actualizar(Ejercicio ejercicio);
        void Eliminar(int id);
        List<Ejercicio> SeleccionarTodos();
        Ejercicio SeleccionarPorId(int id);
    }
}
