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
    public class EntrenamientoDB : IEntrenamientoDB
    {
        public void Actualizar(Entrenamiento entrenamiento)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "usp_UPDATE_Entrenamiento";
                comando.Parameters.AddWithValue("@Id", entrenamiento.Id);
                comando.Parameters.AddWithValue("@Nombre", entrenamiento.Nombre);
                comando.Parameters.AddWithValue("@Descripcion", entrenamiento.Descripcion);
 

                db.ExecuteNonQuery(comando);
            }
        }

        public void Eliminar(int id)
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
                {
                    SqlCommand comandoExamen = new SqlCommand();
                    comandoExamen.CommandType = System.Data.CommandType.StoredProcedure;
                    comandoExamen.CommandText = "usp_DELETE_Entrenamiento_ByID";
                    comandoExamen.Parameters.AddWithValue("@Id", id);

                    db.ExecuteNonQuery(comandoExamen);

                }
            }
            catch (System.Exception)
            {
                throw new System.Exception("Debe eliminar los exámenes asociados a esta certificación");
            }
        }

        public void Insertar(Entrenamiento entrenamiento)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "usp_INSERT_Entrenamiento";
                comando.Parameters.AddWithValue("@Id", entrenamiento.Id);
                comando.Parameters.AddWithValue("@Nombre", entrenamiento.Nombre);
                comando.Parameters.AddWithValue("@Descripcion", entrenamiento.Descripcion);
               
                db.ExecuteNonQuery(comando);
            }
        }

        public Entrenamiento SeleccionarPorId(int id)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "usp_SELECT_Entrenamiento_ByID";
                comando.Parameters.AddWithValue("@Id", id);

                IDataReader reader = db.ExecuteReader(comando);

                while (reader.Read())
                {
                    Entrenamiento entrenamiento = new Entrenamiento();
                    entrenamiento.Id = (int)reader["Id"];
                    entrenamiento.Nombre = reader["Nombre"].ToString();
                    entrenamiento.Descripcion = reader["Descripcion"].ToString();
                  

                    return entrenamiento;
                }
            }

            return null;
        }

        public List<Entrenamiento> SeleccionarTodas()
        {
            List<Entrenamiento> lista = new List<Entrenamiento>();
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "usp_SELECT_Entrenamiento_All";

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Entrenamiento entrenamiento = new Entrenamiento();
                    entrenamiento.Id = (int)dr["Id"];
                    entrenamiento.Nombre = dr["Nombre"].ToString();
                    entrenamiento.Nombre = dr["Descripcion"].ToString();
         

                    lista.Add(entrenamiento);
                }
            }

            return lista;
        }
    }
}
