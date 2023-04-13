using capa.Entidades;
using Capa.Entidades;
using Capa.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Datos
{
    public class FacturaDB : IFacturaDB
    {
        /// <summary>
        /// Método para insertar una factura completa con su Encabezado y sus detalles
        /// </summary>
        /// <param name="encFactura"></param>
        public void Insertar(EncFactura encFactura)
        {
            List<IDbCommand> listaCommands = new List<IDbCommand>();
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comandoDetFactura = new SqlCommand();
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "usp_INSERT_EncabezadoFactura";
                comando.Parameters.AddWithValue("@IdFactura", encFactura.IdFactura);
                comando.Parameters.AddWithValue("@IdTarjeta", encFactura.IdTarjeta);
                comando.Parameters.AddWithValue("@IdUsuario", encFactura.IdUsuario);
                comando.Parameters.AddWithValue("@FechaFacturacion", encFactura.FechaFacturacion);
                comando.Parameters.AddWithValue("@ProximoPago", encFactura.ProximoPago);
                comando.Parameters.AddWithValue("@NumeroTarjeta", encFactura.NumeroTarjeta);
                comando.Parameters.AddWithValue("@Total", encFactura.Total);
               

                listaCommands.Add(comando);

                foreach (DetFactura item in encFactura._ListaFacturaDetalle)
                {
                    comandoDetFactura = new SqlCommand();
                    comandoDetFactura.CommandType = System.Data.CommandType.StoredProcedure;
                    comandoDetFactura.CommandText = "usp_INSERT_DetalleFactura";
                    comandoDetFactura.Parameters.AddWithValue("@IdFactura", item.IdFactura);
                    comandoDetFactura.Parameters.AddWithValue("@Secuencia", item.Secuencia);
                    comandoDetFactura.Parameters.AddWithValue("@IdConcepto", item.IdConcepto);


                    listaCommands.Add(comandoDetFactura);
                }
               
                db.ExecuteNonQuery(listaCommands, IsolationLevel.ReadCommitted);
            }
        }

        /// <summary>
        /// Método para eliminar una factura según su id de Factura
        /// </summary>
        /// <param name="idFactura"></param>
        public void Eliminar(int idFactura)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "usp_DELETE_Factura_ByID";
                comando.Parameters.AddWithValue("@Id", idFactura);

                db.ExecuteNonQuery(comando);
            }
        }

        /// <summary>
        /// Método para seleccionar todas las facturas
        /// </summary>
        /// <returns></returns>
        public List<EncFactura> SeleccionarTodas()
        {
            List<EncFactura> listaa = new List<EncFactura>();
            List<Usuario> lista = new List<Usuario>();
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "usp_SELECT_Factura_All";

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Usuario user = new Usuario();
                    user.Id = dr["Id"].ToString();
                    user.Nombre = dr["Nombre"].ToString();
                    user.Apellidos = dr["Apellidos"].ToString();
                    user.Correo = dr["Correo"].ToString();
                    user.FechaNacimiento = (DateTime)dr["FechaNacimiento"];
                    user.Telefono = (int)dr["Telefono"];
                    user.IdTipoUsuario = (int)dr["IdTipo"];
                    user.Contrasenna = dr["Password"].ToString();
                    user.Imagen = (byte[])dr["Foto"];
                    ITipoUsuarioDB datosUsuario = new TipoUsuarioDB();
                    user._TipoUsuario = datosUsuario.ObtenerPorId(user.IdTipoUsuario);

                    lista.Add(user);
                }
            }

            return listaa;
        }

        /// <summary>
        /// Método para seleccionar una factura por su id
        /// </summary>
        /// <param name="idFactura"></param>
        /// <returns></returns>
        public EncFactura SeleccionarPorId(int idFactura)
        {
            EncFactura oEncFactura = new EncFactura();
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "usp_ObtenerEncyDetFacturaById";
                comando.Parameters.AddWithValue("@IdFactura", idFactura);

                DataSet ds = db.ExecuteDataSet(comando);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    DataRow dr = ds.Tables[0].Rows[0];
                    oEncFactura = new EncFactura()
                    {
                        IdFactura = (int)dr["IdFactura"],
                       
                        IdUsuario = dr["IdUsuario"].ToString(),
                        FechaFacturacion = DateTime.Parse(dr["FechaFacturacion"].ToString()),
                        ProximoPago = DateTime.Parse(dr["ProximoPago"].ToString()),
                        
                  
                        Total = double.Parse(dr["Total"].ToString())
                    };
                    IUsuarioDB datosUsuario = new UsuarioDB();
                    oEncFactura._Usuario = datosUsuario.SeleccionarPorId(oEncFactura.IdUsuario);

                    foreach (var item in ds.Tables[0].Rows)
                    {
                        DetFactura detFactura = new DetFactura();
                        detFactura.IdFactura = int.Parse(dr["IdFactura"].ToString());
                        detFactura.IdFactura = int.Parse(dr["Secuencia"].ToString());
                        detFactura.IdConcepto = int.Parse(dr["IdConcepto"].ToString());
                        
                        //IExamenDB datosExamen = new ExamenDB();

                        //detFactura._Examen = datosExamen.SeleccionarPorId(detFactura.IdExamen);

                        oEncFactura.AddDetalle(detFactura);
                    }
                }
            }
            return oEncFactura;
        }

        /// <summary>
        /// Método para seleccionar el siguiente valor de la secuencia que usamos para el id de nuestra factura
        /// </summary>
        /// <returns></returns>
        public int GetNextNumeroFactura()
        {
            DataSet ds = null;
            IDbCommand command = new SqlCommand();
            int numeroFactura = 0;
            string sql = @"SELECT NEXT VALUE FOR SequenceNoFactura";

            DataTable dt = null;
            try
            {
                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
                {
                    ds = db.ExecuteDataSet(command);
                }

                // Extraer la tabla
                dt = ds.Tables[0];
                //Extraer el valor que viene en el DataTable
                numeroFactura = int.Parse(dt.Rows[0][0].ToString());
                return numeroFactura;
            }
            catch (Exception er)
            {
                throw;
            }
        }

        /// <summary>
        /// Método para seleccionar el valor actual de nuestra secuencia para el id de la factura
        /// </summary>
        /// <returns></returns>
        public int GetCurrentNumeroFactura()
        {
            DataSet ds = null;
            IDbCommand command = new SqlCommand();
            int numeroFactura = 0;
            string sql = @"SELECT current_value FROM sys.sequences WHERE name = 'SequenceNoFactura'  ";
            DataTable dt = null;
            try
            {
                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
                {
                    ds = db.ExecuteDataSet(command);
                }

                // Extraer la tabla
                dt = ds.Tables[0];
                //Extraer el valor que viene en el DataTable
                numeroFactura = int.Parse(dt.Rows[0][0].ToString());
                return numeroFactura;
            }
            catch (Exception er)
            {
                throw;
            }
        }

        public DateTime fechaProximoPagoById(string idUsuario)
        {
            DateTime? validValue = null;


            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                try
                {
                    DataSet ds = null;
                    SqlCommand comando = new SqlCommand();
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.CommandText = "usp_ObtenerProximoPago";
                    comando.Parameters.AddWithValue("@IdUsuario", idUsuario);

                    ds = db.ExecuteDataSet(comando);

                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {

                        DateTime proximoPago = DateTime.Now;
                        proximoPago = (DateTime)dr["ProximoPago"];
                        return proximoPago;
                    }


                    return (DateTime)validValue;
                }catch(Exception ex)
                {
                    throw;
                }
            }
        }
    }
}
