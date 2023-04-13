using Capa.Entidades;
using Capa.Entidades.Cache;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;

namespace capa.Entidades
{
    public class EncFactura
    {
        public int IdFactura { get; set; }
        public double  Total { get; set; }
        public int IdTarjeta { get; set; }
        public string IdUsuario{ get; set; }
        public Usuario _Usuario { get; set; }
        public DateTime FechaFacturacion { get; set; }
        public DateTime ProximoPago { get; set; }
        public int NumeroTarjeta { get; set; }
        //public int IdMulta { get; set; }
        public List<DetFactura> _ListaFacturaDetalle { get; } = new List<DetFactura>();


        /// <summary>
        /// Método que añade detalles de factura
        /// </summary>
        /// <param name="pFacturaDetalle"></param>
        public void AddDetalle(DetFactura pFacturaDetalle)
        {
            _ListaFacturaDetalle.Add(pFacturaDetalle);
        }

        /// <summary>
        /// Método que calcula el impuesto
        /// </summary>
        /// <returns></returns>
        public double getImpuesto()
        {
            return 0.13 * _ListaFacturaDetalle.Sum(p => p._Concepto.Precio);
        }

        /// <summary>
        /// Método que calcula el subtotal
        /// </summary>
        /// <returns></returns>
        public double getSubtotal()
        {
            return _ListaFacturaDetalle.Sum(p => p._Concepto.Precio);
        }


        /// <summary>
        /// Método que calcula el total
        /// </summary>
        /// <returns></returns>
        public double getTotal()
        {

            Total = (0.13 * _ListaFacturaDetalle.Sum(p => p._Concepto.Precio)) + _ListaFacturaDetalle.Sum(p => p._Concepto.Precio);
            return Total;
        }
  
    }
}
