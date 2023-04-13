using capa.Datos;
using capa.Entidades;
using Capa.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Logica.BLL
{
    public class TarjetaLN : ITarjetaLN
    {


        /// <summary>
        /// Método que obtiene tarjeta por id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Tarjeta SeleccionarById(int id)
        {
            ITarjetaDB datos = new TarjetaDB();
            return datos.SeleccionarById(id);
        }
        /// <summary>
        /// Método que selecciona todas las tarjetas
        /// </summary>
        /// <returns></returns>
        public List<Tarjeta> SeleccionarTodas()
        {
            ITarjetaDB datos = new TarjetaDB();
            return datos.SeleccionarTodas();
        }
    }
}
