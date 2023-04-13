using Capa.Datos;
using Capa.Entidades;
using Capa.Interfaces;
using System;
using System.Collections.Generic;

namespace Capa.Logica.BLL
{
    public class EntrenamientoLN : IEntrenamientoLN
    {
        /// <summary>
        /// Método que actualiza el entrenamiento
        /// </summary>
        /// <param name="entrenamiento"></param>
        public void Actualizar(Entrenamiento entrenamiento)
        {
            IEntrenamientoDB datos = new EntrenamientoDB();
            if (datos.SeleccionarPorId(entrenamiento.Id) != null)
            {
                datos.Actualizar(entrenamiento);
            }
            else
            {
                throw new ApplicationException("El entrenamiento que trata de actualizar no existe");
            }
        }
        /// <summary>
        /// Método que elimina el entrenamiento
        /// </summary>
        /// <param name="id"></param>
        public void Eliminar(int id)
        {
            IEntrenamientoDB datos = new EntrenamientoDB();

            if (datos.SeleccionarPorId(id) == null)
                throw new ApplicationException("El código no existe");

            datos.Eliminar(id);
        }
        /// <summary>
        /// Método que guarda el entrenamiento
        /// </summary>
        /// <param name="entrenamiento"></param>
        public void Guardar(Entrenamiento entrenamiento)
        {
            IEntrenamientoDB datos = new EntrenamientoDB();
            if (entrenamiento == null)
                throw new ApplicationException("No existe ninguna certificación");
            if (entrenamiento.Id <= 0)
                throw new ApplicationException("El Id debe ser entero positivo");
            if (entrenamiento.Nombre.Length == 0)
                throw new ApplicationException("El nombre es requerido");
            if (entrenamiento.Descripcion.Length == 0)
                throw new ApplicationException("La descripción es requerido");

            if (datos.SeleccionarPorId(entrenamiento.Id) == null)
            {
                datos.Insertar(entrenamiento);
            }
            else
            {
                datos.Actualizar(entrenamiento);
            }
        }


        /// <summary>
        /// Método que obtiene los entrenamientos
        /// </summary>
        /// <returns></returns>
        public List<Entrenamiento> ObtenerEntrenamientos()
        {
            IEntrenamientoDB datos = new EntrenamientoDB();
            return datos.SeleccionarTodas();
        }
        /// <summary>
        ///  Método que obtiene el entrenamiento por id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Entrenamiento ObtenerEntrenamientosPorId(int id)
        {
            IEntrenamientoDB datos = new EntrenamientoDB();
            return datos.SeleccionarPorId(id);
        }
    }
}