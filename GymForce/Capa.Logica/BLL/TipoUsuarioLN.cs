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
    public class TipoUsuarioLN : ITipoUsuarioLN
    {

        /// <summary>
        /// Método que obtiene el tipo de usuario  por id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public TipoUsuario ObtenerPorId(int id)
        {
            ITipoUsuarioDB datos = new TipoUsuarioDB();
            return datos.ObtenerPorId(id);
        }
        /// <summary>
        /// Método que obtiene todos los tipos de usuarios
        /// </summary>
        /// <returns></returns>
        public List<TipoUsuario> ObtenerTodos()
        {
            ITipoUsuarioDB datos = new TipoUsuarioDB();
            return datos.ObtenerTiposUsuarios();
        }
    }
}
