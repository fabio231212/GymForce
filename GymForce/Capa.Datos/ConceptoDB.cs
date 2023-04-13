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
    public class ConceptoDB : IConceptoDB
    {


        /// <summary>
        /// Este método actualiza el concepto
        /// </summary>
        /// <param name="concepto"></param>
        public void Actualizar(Concepto concepto)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "usp_UPDATE_Concepto";
                comando.Parameters.AddWithValue("@Id", concepto.Id);
                comando.Parameters.AddWithValue("@Nombre", concepto.Nombre);
                comando.Parameters.AddWithValue("@Descripcion", concepto.Descripcion);
                comando.Parameters.AddWithValue("@IdTipo", concepto.Id);
                comando.Parameters.AddWithValue("@Precio", concepto.Precio);

                db.ExecuteNonQuery(comando);
            }
        }

        /// <summary>
        /// Este método eliminar el concepto por el id
        /// </summary>
        /// <param name="id"></param>

        public void Eliminar(int id)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "usp_DELETE_Concepto_ByID";
                comando.Parameters.AddWithValue("@Id", id);

                db.ExecuteNonQuery(comando);
            }
        }


        /// <summary>
        /// Este método selecciona el concepto por filtro
        /// </summary>
        /// <param name="filtro"></param>
        /// <returns></returns>
        public List<Concepto> GetConceptoByFiltro(string filtro)
        {
            DataSet ds = null;
            SqlCommand comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            List<Concepto> lista = new List<Concepto>();
            comando.CommandText = "usp_ObtenerConceptoByFiltro";
            // Pasar Parámetro
            comando.Parameters.AddWithValue("@filtro", filtro);

            // Ejecutar
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                ds = db.ExecuteDataSet(comando, "query");
            }

            // Si devolvió valores
            if (ds.Tables[0].Rows.Count > 0)
            {
                // Itetarar en las filas
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    // Mapear la fila al Objeto
                    Concepto concepto = new Concepto();
                    concepto.Id = (int) dr["Id"];
                    concepto.Nombre = dr["Nombre"].ToString();
                    concepto.Descripcion = dr["Descripcion"].ToString();
                    concepto.Precio = double.Parse( dr["Precio"].ToString());
                    concepto.IdTipo = (int)dr["IdTipo"];

                    ITipoConceptoDB datosTipoConcepto= new TipoConceptoDB();
                    concepto._TipoConcepto = datosTipoConcepto.obtenerTipoConceptoPorId(concepto.IdTipo);


                    lista.Add(concepto);

                }

            }
            return lista;
        }


        /// <summary>
        /// Este método inserta conceptos 
        /// </summary>
        /// <param name="concepto"></param>
        public void Insertar(Concepto concepto)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "usp_INSERT_Concepto";
                comando.Parameters.AddWithValue("@Id", concepto.Id);
                comando.Parameters.AddWithValue("@Nombre", concepto.Nombre);
                    comando.Parameters.AddWithValue("@Descripcion", concepto.Descripcion);
                comando.Parameters.AddWithValue("@IdTipo", concepto.IdTipo);
                comando.Parameters.AddWithValue("@Precio", concepto.Precio);


                db.ExecuteNonQuery(comando);
            }
        }


        /// <summary>
        /// Selecciona el concepto por id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Concepto SeleccionarPorId(int id)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "usp_SELECT_Concepto_ByID";
                comando.Parameters.AddWithValue("@Id", id);

                IDataReader reader = db.ExecuteReader(comando);

                while (reader.Read())
                {
                    Concepto concepto = new Concepto();
                    concepto.Id = (int) reader["Id"];
                    concepto.Nombre = reader["Nombre"].ToString();
                    concepto.Descripcion = reader["Descripcion"].ToString();
                    concepto.IdTipo = (int) reader["IdTipo"];
                    concepto.Precio=double.Parse(reader["Precio"].ToString());


                    return concepto;
                }
            }

            return null;
        }


        /// <summary>
        /// Selecciona todos los conceptos
        /// </summary>
        /// <returns></returns>
        public List<Concepto> SeleccionarTodas()
        {
            List<Concepto> lista = new List<Concepto>();
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "usp_SELECT_Concepto_All";

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Concepto concepto = new Concepto();
                    concepto.Id = (int) dr["Id"];
                    concepto.Nombre = dr["Nombre"].ToString();
                    concepto.Descripcion = dr["Descripcion"].ToString();
                    concepto.IdTipo =(int) dr["IdTipo"];
                    concepto.Precio =  double.Parse( dr["Precio"].ToString());

                  

                    lista.Add(concepto);
                }
            }

            return lista;
        }



        /// <summary>
        /// Actualiza el valor de la multa
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="precio"></param>
        public void UpdateConceptoMulta(int Id, double precio)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "usp_UpdateConceptoById";
                comando.Parameters.AddWithValue("@IdConcepto",Id );
                comando.Parameters.AddWithValue("@Precio", precio);

                db.ExecuteNonQuery(comando);
            }
        }
    }
}
