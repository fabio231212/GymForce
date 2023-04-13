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
    public class EjercicioLN : IEjercicioLN
    {
        /// <summary>
        /// Método que actualiza el ejercicio
        /// </summary>
        /// <param name="ejercicio"></param>
        public void Actualizar(Ejercicio ejercicio)
        {
            IEjercicioDB datos = new EjercicioDB();
            datos.Actualizar(ejercicio);
        }

        /// <summary>
        /// Método que elimina por el id
        /// </summary>
        /// <param name="id"></param>
        public void Eliminar(int id)
        {
            IEjercicioDB datos = new EjercicioDB();
            datos.Eliminar(id);
        }

        /// <summary>
        /// Método que guarda el ejercicio
        /// </summary>
        /// <param name="ejercicio"></param>
        public void Guardar(Ejercicio ejercicio)
        {
            IEjercicioDB datos = new EjercicioDB();
            datos.Insertar(ejercicio);
        }

        /// <summary>
        /// Método que obtiene el ejercicio por id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Ejercicio ObtenerEjercicioPorId(int id)
        {
            IEjercicioDB datos = new EjercicioDB();
            return datos.SeleccionarPorId(id);
        }
        /// <summary>
        /// Método que obtiene todos los ejercicios
        /// </summary>
        /// <returns></returns>
        public List<Ejercicio> ObtenerEjercicios()
        {
            IEjercicioDB datos = new EjercicioDB();
            return datos.SeleccionarTodos();
        }
    }
}
