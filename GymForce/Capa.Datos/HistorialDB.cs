using Capa.Entidades.Cache;
using Capa.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Datos
{
    public class HistorialDB : IHistorialDB
    {
        public void Guardar()
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "usp_INSERT_IngresoHistorial";
                comando.Parameters.AddWithValue("@Entrada", HistorialCache.Ingreso);
                comando.Parameters.AddWithValue("@Salida", HistorialCache.Salida);
                comando.Parameters.AddWithValue("@IdUsuario", HistorialCache.IdUsuario);


                db.ExecuteNonQuery(comando);
            }
        }
    }
}
