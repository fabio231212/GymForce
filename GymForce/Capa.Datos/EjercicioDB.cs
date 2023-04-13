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
    public class EjercicioDB : IEjercicioDB
    {



        /// <summary>
        /// Este método actualiza el ejercicio mandado por parámetro
        /// </summary>
        /// <param name="ejercicio"></param>
        public void Actualizar(Ejercicio ejercicio)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "usp_UPDATE_Ejercicio";
                comando.Parameters.AddWithValue("@Id", ejercicio.Id);
                comando.Parameters.AddWithValue("@Nombre", ejercicio.Nombre);
                comando.Parameters.AddWithValue("@Descripcion", ejercicio.Descripcion);
                comando.Parameters.AddWithValue("@Imagen", ejercicio.Imagen);
                comando.Parameters.AddWithValue("@IdTipoEjercicio", ejercicio.IdTipoEjercicio);
                comando.Parameters.AddWithValue("@IdEntrenamiento", ejercicio.IdEntrenamiento);
                comando.Parameters.AddWithValue("@Peso", ejercicio.Peso);
                comando.Parameters.AddWithValue("@CantRepeticiones", ejercicio.CantRepeticiones);
                comando.Parameters.AddWithValue("@Series", ejercicio.Series);
                comando.Parameters.AddWithValue("@TiempoRepeDesc", ejercicio.TiempoDescanso);

                db.ExecuteNonQuery(comando);
            }
        }


        /// <summary>
        /// Este método elimina el ejercicio con el id que va por parámetro
        /// </summary>
        /// <param name="id"></param>

        public void Eliminar(int id)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "usp_DELETE_Ejercicio_ByID";
                comando.Parameters.AddWithValue("@Id", id);

                db.ExecuteNonQuery(comando);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ejercicio"></param>
        public void Insertar(Ejercicio ejercicio)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "usp_INSERT_Ejercicio";
                comando.Parameters.AddWithValue("@Id", ejercicio.Id);
                comando.Parameters.AddWithValue("@Nombre", ejercicio.Nombre);
                comando.Parameters.AddWithValue("@Descripcion", ejercicio.Descripcion);
                comando.Parameters.AddWithValue("@Imagen", ejercicio.Imagen);
                comando.Parameters.AddWithValue("@IdTipoEjercicio", ejercicio.IdTipoEjercicio);
                comando.Parameters.AddWithValue("@IdEntrenamiento", ejercicio.IdEntrenamiento);
                comando.Parameters.AddWithValue("@Peso", ejercicio.Peso);
                comando.Parameters.AddWithValue("@CantRepeticiones", ejercicio.CantRepeticiones);
                comando.Parameters.AddWithValue("@Series", ejercicio.Series);
                comando.Parameters.AddWithValue("@TiempoRepeDesc", ejercicio.TiempoDescanso);
                db.ExecuteNonQuery(comando);
            }
        }

        public Ejercicio SeleccionarPorId(int id)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "usp_SELECT_Ejercicio_ByID";
                comando.Parameters.AddWithValue("@Id", id);

                IDataReader reader = db.ExecuteReader(comando);

                while (reader.Read())
                {
                    Ejercicio ejercicio = new Ejercicio();
                    ejercicio.Id = (int)reader["Id"];
                    ejercicio.Nombre = reader["Nombre"].ToString();
                    ejercicio.Descripcion = reader["Descripcion"].ToString();
                    ejercicio.Imagen = (byte[])reader["Imagen"];
                    ejercicio.IdTipoEjercicio = (int)reader["IdTipoEjercicio"];
                    ejercicio.IdEntrenamiento = (int)reader["IdEntrenamiento"];
                    ejercicio.Peso = double.Parse(reader["Peso"].ToString());
                    ejercicio.Series = (int)reader["Series"];
                    ejercicio.CantRepeticiones = (int)reader["CantRepeticiones"];
                    ejercicio.TiempoDescanso = (int)reader["TiempoRepeDesc"];

                    IEntrenamientoDB datosEntrenamiento = new EntrenamientoDB();
                    ITipoEjercicioDB datosTipoEjercicio = new TipoEjercicioDB();
                    ejercicio._Entrenamiento = datosEntrenamiento.SeleccionarPorId(ejercicio.IdEntrenamiento);
                    ejercicio._TipoEjercicio = datosTipoEjercicio.ObtenerPorId(ejercicio.IdTipoEjercicio);

                    return ejercicio;
                }
            }
            return null;
        }

        public List<Ejercicio> SeleccionarTodos()
        {
            List<Ejercicio> lista = new List<Ejercicio>();
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "usp_SELECT_Ejercicio_All";

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Ejercicio ejercicio = new Ejercicio();
                    ejercicio.Id = (int)dr["Id"];
                    ejercicio.Nombre = dr["Nombre"].ToString();
                    ejercicio.Descripcion = dr["Descripcion"].ToString();
                    ejercicio.Imagen = (byte[])dr["Imagen"];
                    ejercicio.IdTipoEjercicio = (int)dr["IdTipoEjercicio"];
                    ejercicio.IdEntrenamiento = (int)dr["IdEntrenamiento"];
                    ejercicio.Peso = double.Parse(dr["Peso"].ToString());
                    ejercicio.Series = (int)dr["Series"];
                    ejercicio.CantRepeticiones = (int)dr["CantRepeticiones"];
                    ejercicio.TiempoDescanso = (int)dr["TiempoRepeDesc"];
                    IEntrenamientoDB datosEntrenamiento =new EntrenamientoDB();
                    ejercicio._Entrenamiento = datosEntrenamiento.SeleccionarPorId(ejercicio.IdEntrenamiento);
                    ITipoEjercicioDB datosTipoEjercicio = new TipoEjercicioDB();
                    ejercicio._TipoEjercicio = datosTipoEjercicio.ObtenerPorId(ejercicio.IdTipoEjercicio);


                    lista.Add(ejercicio);
                }
            }

            return lista;
        }
    }
}
