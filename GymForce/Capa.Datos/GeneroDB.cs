using capa.Entidades;
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
    public class GeneroDB : IGeneroDB
    {


        /// <summary>
        /// Método para seleccionar el país por su id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Genero SeleccionarPorId(int id)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "usp_SELECT_Genero_ByID";
                comando.Parameters.AddWithValue("@Id", id);

                IDataReader reader = db.ExecuteReader(comando);

                while (reader.Read())
                {
                    Genero genero = new Genero();
                    genero.Id = (int)reader["Id"];
                    genero.Descripcion = reader["Descripcion"].ToString();
                    return genero;
                }
            }

            return null;
        }

        /// <summary>
        /// Método para seleccionar todos los países incluidos en la base de datos
        /// </summary>
        /// <returns></returns>
        public List<Genero> SeleccionarTodas()
        {
            List<Genero> lista = new List<Genero>();
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "usp_SELECT_Genero_All";

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Genero genero = new Genero();
                    genero.Id = (int)dr["Id"];
                    genero.Descripcion = dr["Descripcion"].ToString();
                    lista.Add(genero);
                }
            }

            return lista;
        }
    }

        
        
    
}
