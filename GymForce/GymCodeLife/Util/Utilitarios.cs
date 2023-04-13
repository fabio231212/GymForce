using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Capa.UI.Util
{
    class Utilitarios
    {
        public static void CultureInfo()
        {
            // Colocar Cultura Estandar para Costa Rica
            // esto me permite no tener problemas con (.) de los decimales
            CultureInfo Micultura = new CultureInfo("es-CR", false);
            Micultura.NumberFormat.CurrencySymbol = "¢";
            Micultura.NumberFormat.CurrencyDecimalDigits = 2;
            Micultura.NumberFormat.CurrencyDecimalSeparator = ".";
            Micultura.NumberFormat.CurrencyGroupSeparator = ",";
            int[] grupo = new int[] { 3, 3, 3 };
            Micultura.NumberFormat.CurrencyGroupSizes = grupo;
            Micultura.NumberFormat.NumberDecimalDigits = 2;
            Micultura.NumberFormat.NumberGroupSeparator = ",";
            Micultura.NumberFormat.NumberDecimalSeparator = ".";
            Micultura.NumberFormat.NumberGroupSizes = grupo;
            //Micultura.DateTimeFormat.
            Thread.CurrentThread.CurrentCulture = Micultura;
        }
        public static double  ConsumoDolar()
        {
            string correoRegistrado = "fabramirezro@est.utn.ac.cr";
            string token = "R0ACBR0AE2";
            string nombreRegistrado = "Fabio";
            try
            {
                // Habilitar TLS12
                System.Net.ServicePointManager.SecurityProtocol =
                                              SecurityProtocolType.Tls12;
                // wsindicadoreseconomicosSoap12 Binding tomado del app.Config
                Agente.wsindicadoreseconomicosSoapClient cliente =
                     new Agente.wsindicadoreseconomicosSoapClient("wsindicadoreseconomicosSoap12");

                DataSet dolar = cliente.ObtenerIndicadoresEconomicos("317",    /* 317 Compra / 318 Venta */
                                                                  "06/01/2020",      /* Fecha Inicial */
                                                                  "08/01/2020",      /* Fecha Final */
                                                                  nombreRegistrado,  /* Su Nombre Registrado   BCCR */
                                                                  "N",
                                                                  correoRegistrado, /* Correo Registrado BCCR */
                                                                  token             /* Token enviado por el BCCR */
                                                                 );
                double a = (double)dolar.Tables[0].Rows[2].Field<decimal>("NUM_VALOR");
                return a;
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
