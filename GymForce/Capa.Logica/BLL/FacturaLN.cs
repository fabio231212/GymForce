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
    public class FacturaLN : IFacturaLN
    {

        /// <summary>
        /// Método que elimina la factura
        /// </summary>
        /// <param name="idFactura"></param>
        public void Eliminar(int idFactura)
        {
            IFacturaDB datos = new FacturaDB();
            datos.Eliminar(idFactura);
        }


        /// <summary>
        /// Método que trae la fecha de pago
        /// </summary>
        /// <param name="idUsuario"></param>
        /// <returns></returns>
        public DateTime fechaProximoPagoById(string idUsuario)
        {
            IFacturaDB datos = new FacturaDB();
            return datos.fechaProximoPagoById(idUsuario);
        }

        /// <summary>
        /// Método que trae el actual número de factura
        /// </summary>
        /// <returns></returns>
        public int GetCurrentNumeroFactura()
        {
            IFacturaDB datos = new FacturaDB();
           return datos.GetCurrentNumeroFactura();
        }

        /// <summary>
        /// Método que trae el siguiente número de factura
        /// </summary>
        /// <returns></returns>
        public int GetNextNumeroFactura()
        {
            IFacturaDB datos = new FacturaDB();
            return datos .GetNextNumeroFactura();
        }


        /// <summary>
        /// Método que guarda la factura
        /// </summary>
        /// <param name="encFactura"></param>
        public void Guardar(EncFactura encFactura)
        {
            IFacturaDB datos = new FacturaDB();
            datos.Insertar(encFactura);
        }

        /// <summary>
        /// Método que selecciona la factura por ids
        /// </summary>
        /// <param name="idFactura"></param>
        /// <returns></returns>
        public EncFactura SeleccionarPorId(int idFactura)
        {
            IFacturaDB datos = new FacturaDB();
            return datos.SeleccionarPorId(idFactura);
            
        }
        /// <summary>
        /// Método que selecciona todas las facturas
        /// </summary>
        /// <returns></returns>
        public List<EncFactura> SeleccionarTodas()
        {
            IFacturaDB datos = new FacturaDB();
            return datos.SeleccionarTodas();
        }
    }
}
