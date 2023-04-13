using capa.Entidades;
using Capa.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa.Datos
{
    public class TarjetaDB : ITarjetaDB
    {

        /// <summary>
        /// Método para seleccionar tarjeta según su id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public  Tarjeta SeleccionarById(int id)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "usp_SELECT_Tarjeta_ByID";
                comando.Parameters.AddWithValue("@ID", id);

                IDataReader reader = db.ExecuteReader(comando);

                while (reader.Read())
                {
                    Tarjeta tarjeta = new Tarjeta();
                    tarjeta.Id = (int)reader["Id"];
                    tarjeta.Nombre = reader["Nombre"].ToString();


                    return tarjeta;
                }
                return null;
            }
        }

        /// <summary>
        /// Método para obtener todas las tarjetas disponibles en la base de datos
        /// </summary>
        /// <returns></returns>
        public  List<Tarjeta> SeleccionarTodas()
        {
            List<Tarjeta> lista = new List<Tarjeta>();
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "usp_SELECT_Tarjeta_All";

                IDataReader reader = db.ExecuteReader(comando);

                while (reader.Read())
                {
                    Tarjeta tarjeta = new Tarjeta();
                    tarjeta.Id = (int)reader["Id"];
                    tarjeta.Nombre= reader["Nombre"].ToString();

                    lista.Add(tarjeta);

                }
            }

            return lista;
        }
    }
}
