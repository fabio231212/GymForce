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
    public class UsuarioxEntrenamientoDB : IUsuarioxEntrenamientoDB
    {
        public void Actualizar(UsuarioxEntrenamiento datos)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "usp_UPDATE_UsuarioxEntrenamiento";
                //comando.Parameters.AddWithValue("@Id", datos.Id);
                comando.Parameters.AddWithValue("@IdEntrenamiento", datos.IdEntrenamiento);
                comando.Parameters.AddWithValue("@IdUsuario", datos.IdUsuario);
                comando.Parameters.AddWithValue("@Dia", datos.Dia);



                db.ExecuteNonQuery(comando);
            }
        }

        public void Eliminar(string idUsuario,int idEntrenamiento)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "usp_DELETE_UsuarioxEntrenamiento_ByID";
                comando.Parameters.AddWithValue("@IdUsuario", idUsuario);
                comando.Parameters.AddWithValue("@IdEntrenamiento", idEntrenamiento);


                db.ExecuteNonQuery(comando);
            }
        }

        public void guardar(UsuarioxEntrenamiento datos)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "usp_INSERT_UsuarioxEntrenamiento";
                //comando.Parameters.AddWithValue("@Id", datos.Id);
                comando.Parameters.AddWithValue("@IdEntrenamiento", datos.IdEntrenamiento);
                comando.Parameters.AddWithValue("@IdUsuario", datos.IdUsuario);
                comando.Parameters.AddWithValue("@Dia", datos.Dia);
                db.ExecuteNonQuery(comando);
            }
        }

        public List<UsuarioxEntrenamiento> ObtenerDatos()
        {
            List<UsuarioxEntrenamiento> lista = new List<UsuarioxEntrenamiento>();
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "usp_SELECT_UsuarioxEntrenamiento_All";

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    UsuarioxEntrenamiento datos = new UsuarioxEntrenamiento();
                    datos.Id = (int)dr["Id"];
                    datos.IdEntrenamiento = (int)dr["IdEntrenamiento"];
                    datos.IdUsuario = dr["IdUsuario"].ToString();
                    datos.Dia = dr["Dia"].ToString();



                    lista.Add(datos);
                }
            }

            return lista;
        }

        public List<UsuarioxEntrenamiento> ObtenerDatosByIdUsuario(string idUsuario)
        {
            List<UsuarioxEntrenamiento> lista = new List<UsuarioxEntrenamiento>();
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "usp_SelectEntrenamientoByIdUser";
                comando.Parameters.AddWithValue("@IdUsuario", idUsuario);

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    UsuarioxEntrenamiento datos = new UsuarioxEntrenamiento();
                    datos.Id = (int)dr["Id"];
                    datos.IdEntrenamiento = (int)dr["IdEntrenamiento"];
                    datos.IdUsuario = dr["IdUsuario"].ToString();
                    datos.Dia = dr["Dia"].ToString();


                    lista.Add(datos);
                }
            }

            return lista;
        }

        public UsuarioxEntrenamiento ObtenerDatosPorId(string idUsuario, int idEntrenamiento)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "usp_SELECT_UsuarioxEntrenamiento_ByID";
                comando.Parameters.AddWithValue("@IdUsuario", idUsuario);
                comando.Parameters.AddWithValue("@IdEntrenamiento", idEntrenamiento);



                IDataReader reader = db.ExecuteReader(comando);

                while (reader.Read())
                {
                    UsuarioxEntrenamiento UsuarioxEntrenamiento = new UsuarioxEntrenamiento();
                    UsuarioxEntrenamiento.Id = (int)reader["Id"];
                    UsuarioxEntrenamiento.IdEntrenamiento = (int)reader["IdUsuario"];
                    UsuarioxEntrenamiento.IdUsuario = reader["IdEntrenamiento"].ToString();
                    UsuarioxEntrenamiento.Dia = reader["Dia"].ToString();


                    return UsuarioxEntrenamiento;
                }
            }
            return null;
        }
    }
}
