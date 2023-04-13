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
    public class TipoEjercicioLN : ITipoEjercicioLN
    {
        /// <summary>
        /// Tipo de ejercicio por id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public TipoEjercicio ObtenerPorId(int id)
        {
            ITipoEjercicioDB datos = new TipoEjercicioDB();
            return datos.ObtenerPorId(id); ;
        }

        /// <summary>
        /// obtiene todos los tipos de ejercicio
        /// </summary>
        /// <returns></returns>
        public List<TipoEjercicio> ObtenerTodos()
        {
            ITipoEjercicioDB datos = new TipoEjercicioDB();
            return datos.ObtenerTiposEjercicios();
        }
    }
}
