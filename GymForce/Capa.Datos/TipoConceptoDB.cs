using Capa.Entidades;
using Capa.Interfaces;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Capa.Datos
{
    public class TipoConceptoDB : ITipoConceptoDB
    {
        public TipoConcepto obtenerTipoConceptoPorId(int id)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "usp_SELECT_TipoConcepto_ByID";
                comando.Parameters.AddWithValue("@Id", id);

                IDataReader reader = db.ExecuteReader(comando);

                while (reader.Read())
                {
                    TipoConcepto tipoConcepto = new TipoConcepto();
                    tipoConcepto.Id = (int)reader["Id"];
                    tipoConcepto.Nombre = reader["Nombre"].ToString();

                    return tipoConcepto;
                }
            }

            return null;
        }

        public List<TipoConcepto> obtenerTipoConceptos()
        {
            List<TipoConcepto> lista = new List<TipoConcepto>();
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "usp_SELECT_TipoConcepto_All";

                IDataReader reader = db.ExecuteReader(comando);

                while (reader.Read())
                {
                    TipoConcepto tipoConcepto = new TipoConcepto();
                    tipoConcepto.Id = (int)reader["Id"];
                    tipoConcepto.Nombre = reader["Nombre"].ToString();

                    lista.Add(tipoConcepto);
                }
            }

            return lista;
        }
    }
}