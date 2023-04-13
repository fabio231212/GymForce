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
    public class UsuarioxEntrenamientoLN : IUsuarioxEntrenamientoLN
    {

        /// <summary>
        /// Método que actualiza UsuarioxEntrenamiento
        /// </summary>
        /// <param name="datos"></param>
        public void Actualizar(UsuarioxEntrenamiento datos)
        {
            IUsuarioxEntrenamientoDB logicaDatos = new UsuarioxEntrenamientoDB();
            logicaDatos.Actualizar(datos);
        }


        /// <summary>
        /// Método que elimina usuarioxEntrenamiento
        /// </summary>
        /// <param name="idUsuario"></param>
        /// <param name="idEntrenamiento"></param>
        public void Eliminar(string idUsuario, int idEntrenamiento)
        {
            IUsuarioxEntrenamientoDB logicaDatos = new UsuarioxEntrenamientoDB();
            logicaDatos.Eliminar(idUsuario,idEntrenamiento);
        }

        public void Guardar(UsuarioxEntrenamiento datos)
        {
            IUsuarioxEntrenamientoDB logicaDatos = new UsuarioxEntrenamientoDB();
            logicaDatos.guardar(datos);
        }

        public List<UsuarioxEntrenamiento> ObtenerDatos()
        {
            IUsuarioxEntrenamientoDB logicaDatos = new UsuarioxEntrenamientoDB();
            return logicaDatos.ObtenerDatos();
        }

        public List<UsuarioxEntrenamiento> ObtenerDatosByIdUsuario(string idUsuario)
        {
            IUsuarioxEntrenamientoDB logicaDatos = new UsuarioxEntrenamientoDB();
            return logicaDatos.ObtenerDatosByIdUsuario(idUsuario);
        }

        public UsuarioxEntrenamiento ObtenerDatosPorId(string idUsuario, int idEntrenamiento)
        {
            IUsuarioxEntrenamientoDB logicaDatos = new UsuarioxEntrenamientoDB();
            return logicaDatos.ObtenerDatosPorId(idUsuario, idEntrenamiento);
        }
    }
}
