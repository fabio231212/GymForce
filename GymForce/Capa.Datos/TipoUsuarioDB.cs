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
    public class TipoUsuarioDB : ITipoUsuarioDB
    {
        /// <summary>
        /// Método para obtener el tipo de usuario según su id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public TipoUsuario ObtenerPorId(int id)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "usp_SELECT_TipoUsuario_ByID";
                comando.Parameters.AddWithValue("@Id", id);

                IDataReader reader = db.ExecuteReader(comando);

                while (reader.Read())
                {
                    TipoUsuario tipoUsuario = new TipoUsuario();
                    tipoUsuario.Id = (int)reader["Id"];
                    tipoUsuario.Descripcion = reader["Descripcion"].ToString();

                    return tipoUsuario;
                }
            }

            return null;
        }
        /// <summary>
        /// Método para obtener todos los tipos de usuarios disponibles de la base de datos
        /// </summary>
        /// <returns></returns>
        public List<TipoUsuario> ObtenerTiposUsuarios()
        {
            List<TipoUsuario> lista = new List<TipoUsuario>();
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "usp_SELECT_TipoUsuario_All";

                IDataReader reader = db.ExecuteReader(comando);

                while (reader.Read())
                {
                    TipoUsuario tipoUsuario = new TipoUsuario();
                    tipoUsuario.Id = (int)reader["Id"];
                    tipoUsuario.Descripcion = reader["Descripcion"].ToString();

                    lista.Add(tipoUsuario);
                }
            }

            return lista;
        }
    }
}
