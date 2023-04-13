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
    public class TipoEjercicioDB : ITipoEjercicioDB
    {
        public TipoEjercicio ObtenerPorId(int id)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "usp_SELECT_TipoEjercicio_ByID";
                comando.Parameters.AddWithValue("@Id", id);

                IDataReader reader = db.ExecuteReader(comando);

                while (reader.Read())
                {
                    TipoEjercicio tipoEjercicio = new TipoEjercicio();
                    tipoEjercicio.Id = (int)reader["Id"];
                    tipoEjercicio.Nombre = reader["Nombre"].ToString();
                    tipoEjercicio.Descripcion = reader["Descripcion"].ToString();
                    return tipoEjercicio;
                }
            }

            return null;
        }

        public List<TipoEjercicio> ObtenerTiposEjercicios()
        {
            List<TipoEjercicio> lista = new List<TipoEjercicio>();
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "usp_SELECT_TipoEjercicio_All";

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    TipoEjercicio tipoEjercicio = new TipoEjercicio();
                    tipoEjercicio.Id = (int)dr["Id"];
                    tipoEjercicio.Nombre = dr["Nombre"].ToString();
                    tipoEjercicio.Descripcion = dr["Descripcion"].ToString();
                    lista.Add(tipoEjercicio);
                }
            }

            return lista;
        }
    }
}
