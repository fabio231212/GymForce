using Capa.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Interfaces
{
    public interface IUsuarioxEntrenamientoDB
    {
        void guardar(UsuarioxEntrenamiento datos);
        void Actualizar(UsuarioxEntrenamiento datos);
        void Eliminar(string idUsuario, int idEntrenamiento);
        UsuarioxEntrenamiento ObtenerDatosPorId(string idUsuario, int idEntrenamiento);
        List<UsuarioxEntrenamiento> ObtenerDatos();

        List<UsuarioxEntrenamiento> ObtenerDatosByIdUsuario(string idUsuario);


    }
}
