using Capa.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Interfaces
{
    public interface IEjercicioLN
    {
        void Guardar(Ejercicio ejercicio);
        void Actualizar(Ejercicio ejercicio);
        void Eliminar(int id);
        Ejercicio ObtenerEjercicioPorId(int id);
        List<Ejercicio> ObtenerEjercicios();
    }
}
