using capa.Entidades;
using Capa.Datos;
using Capa.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Logica.BLL
{
    public class GeneroLN : IGeneroLN
    {
        /// <summary>
        /// Método para seleccionar todos los generos disponibles
        /// </summary>
        /// <returns></returns>
        public List<Genero> ObtenerGenero()
        {
            IGeneroDB datos = new GeneroDB();
            return datos.SeleccionarTodas();
        }
        /// <summary>
        /// Método para obtener un genero según su id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Genero ObtenerPorId(int id)
        {
            IGeneroDB datosPais = new GeneroDB();
            return datosPais.SeleccionarPorId(id);
        }
    }
}
