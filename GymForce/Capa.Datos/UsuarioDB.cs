using Capa.Entidades;
using Capa.Entidades.Cache;
using Capa.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Capa.Datos
{
    public class UsuarioDB : IUsuarioDB
    {
        /// <summary>
        /// Método para insertar un Usuario en la base de datos
        /// </summary>
        /// <param name="user"></param>
        public void Insertar(Usuario user)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "usp_INSERT_Usuario";
                comando.Parameters.AddWithValue("@Id", user.Id);
                comando.Parameters.AddWithValue("@Nombre", user.Nombre);
                comando.Parameters.AddWithValue("@Apellidos", user.Apellidos);
                comando.Parameters.AddWithValue("@Correo", user.Correo);
                comando.Parameters.AddWithValue("@Password", user.Contrasenna);
                comando.Parameters.AddWithValue("@FechaNacimiento", user.FechaNacimiento);
                comando.Parameters.AddWithValue("@Telefono", user.Telefono);
                comando.Parameters.AddWithValue("@IdGenero", user.IdGenero);
                comando.Parameters.AddWithValue("@Peso", user.Peso);
                comando.Parameters.AddWithValue("@Altura", user.Altura);
                comando.Parameters.AddWithValue("@MetabolismoBasal", user.MetabolismoBasal);
                comando.Parameters.AddWithValue("@IMC", user.IMC);
                comando.Parameters.AddWithValue("@IdTipo", user.IdTipoUsuario);
                comando.Parameters.AddWithValue("@Foto", user.Imagen);

                db.ExecuteNonQuery(comando);
            }
        }

        /// <summary>
        /// Método para actualizar un usuario ya insertado de la base de datos
        /// </summary>
        /// <param name="user"></param>
        public void Actualizar(Usuario user)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "usp_UPDATE_Usuario";
                comando.Parameters.AddWithValue("@Id", user.Id);
                comando.Parameters.AddWithValue("@Nombre", user.Nombre);
                comando.Parameters.AddWithValue("@Apellidos", user.Apellidos);
                comando.Parameters.AddWithValue("@Correo", user.Correo);
                comando.Parameters.AddWithValue("@Password", user.Contrasenna);
                comando.Parameters.AddWithValue("@FechaNacimiento", user.FechaNacimiento);
                comando.Parameters.AddWithValue("@Telefono", user.Telefono);
                comando.Parameters.AddWithValue("@IdGenero", user.IdGenero);
                comando.Parameters.AddWithValue("@Peso", user.Peso);
                comando.Parameters.AddWithValue("@Altura", user.Altura);
                comando.Parameters.AddWithValue("@MetabolismoBasal", user.MetabolismoBasal);
                comando.Parameters.AddWithValue("@IMC", user.IMC);
                comando.Parameters.AddWithValue("@IdTipo", user.IdTipoUsuario);
                comando.Parameters.AddWithValue("@Foto", user.Imagen);

                db.ExecuteNonQuery(comando);
            }
        }

        /// <summary>
        /// Método para eliminar un usuario de la base de datos según su id
        /// </summary>
        /// <param name="id"></param>
        public void Eliminar(string id)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "usp_DELETE_Usuario_ByID";
                comando.Parameters.AddWithValue("@Id", id);

                db.ExecuteNonQuery(comando);
            }
        }

        /// <summary>
        /// Método para obtener todos los usuarios almacenados en la base de datos
        /// </summary>
        /// <returns></returns>
        public List<Usuario> SeleccionarTodas()
        {
            List<Usuario> lista = new List<Usuario>();
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "usp_SELECT_Usuario_All";

                DataSet ds = db.ExecuteDataSet(comando);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Usuario user = new Usuario();
                    user.Id = dr["Id"].ToString();
                    user.Nombre = dr["Nombre"].ToString();
                    user.Apellidos = dr["Apellidos"].ToString();
                    user.Correo = dr["Correo"].ToString();
                    user.Contrasenna = dr["password"].ToString();
                    user.FechaNacimiento = (DateTime)dr["FechaNacimiento"];
                    user.Telefono = (int)dr["Telefono"];
                    user.IdTipoUsuario = (int)dr["IdTipo"];
                    user.Imagen = (byte[])dr["Foto"];
                    user.IdGenero = (int)dr["IdGenero"];
                    user.IMC = (double)Convert.ToDouble(dr["IMC"]);
                    user.MetabolismoBasal = (double)Convert.ToDouble(dr["MetabolismoBasal"]);
                    user.Peso = (double)dr["Peso"];
                    user.Altura = double.Parse(dr["Altura"].ToString());

                    ITipoUsuarioDB datosUsuario = new TipoUsuarioDB();
                    user._TipoUsuario = datosUsuario.ObtenerPorId(user.IdTipoUsuario);

                    lista.Add(user);
                }
            }

            return lista;
        }

        /// <summary>
        /// Método para seleccionar usuario de la base de datos según su id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Usuario SeleccionarPorId(string id)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "usp_SELECT_Usuario_ByID";
                comando.Parameters.AddWithValue("@Id", id);

                IDataReader reader = db.ExecuteReader(comando);

                while (reader.Read())
                {
                  Usuario user = new Usuario();
                    user.Id = reader["Id"].ToString();
                    user.Nombre = reader["Nombre"].ToString();
                    user.Apellidos = reader["Apellidos"].ToString();
                    user.Correo = reader["Correo"].ToString();
                    user.Contrasenna = reader["password"].ToString();
                    user.FechaNacimiento = (DateTime)reader["FechaNacimiento"];
                    user.Telefono = (int)reader["Telefono"];
                    user.IdTipoUsuario = (int)reader["IdTipo"];
                    user.Imagen = (byte[])reader["Foto"];
                    user.IdGenero = (int)reader["IdGenero"];
                    user.IMC = (double)Convert.ToDouble(reader["IdGenero"]);
                    user.MetabolismoBasal = (double)Convert.ToDouble(reader["MetabolismoBasal"]);
                    user.Peso = (double)Convert.ToDouble(reader["Peso"]);
                    user.Altura = (double)Convert.ToDouble(reader["Altura"]);

                    ITipoUsuarioDB datosUsuario = new TipoUsuarioDB();
                    user._TipoUsuario = datosUsuario.ObtenerPorId(user.IdTipoUsuario);

                    return user;
                }
            }

            return null;
        }

        /// <summary>
        /// Método para verificar que el correo y la contraseña digitadas sean de un usuario de la base de datos
        /// </summary>
        /// <param name="correo"></param>
        /// <param name="contrasenna"></param>
        /// <returns></returns>
        public bool VerificarLogin(string correo, string contrasenna)
        {
            bool resultado = false;
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "PA_Verificar_Login";
                comando.Parameters.AddWithValue("@Correo", correo);
                comando.Parameters.AddWithValue("@Password", contrasenna);

                IDataReader reader = db.ExecuteReader(comando);

                while (reader.Read())
                {
                    
                    UsuarioCache.Id = reader["Id"].ToString();
                    UsuarioCache.Nombre = reader["Nombre"].ToString();
                    UsuarioCache.Apellidos = reader["Apellidos"].ToString();
                    UsuarioCache.Correo = reader["Correo"].ToString();
                    UsuarioCache.FechaNacimiento = (DateTime)reader["FechaNacimiento"];
                    UsuarioCache.Telefono = (int)reader["Telefono"];
                    UsuarioCache.IdTipoUsuario = (int)reader["IdTipo"];
                    UsuarioCache.Contrasenna = reader["Password"].ToString();
                    UsuarioCache.IdGenero = (int) reader["IdGenero"];
                    UsuarioCache.IdTipoUsuario = (int)reader["IdTipo"];
                    var a = reader["Foto"];
                    if (!a.GetType().ToString().Equals("System.DBNull"))
                    {
                        UsuarioCache.Imagen = (byte[])reader["Foto"];
                    }
                    else
                    {
                        UsuarioCache.Imagen = null;
                    }
                    UsuarioCache.IMC = double.Parse(reader["IMC"].ToString());
                    UsuarioCache.MetabolismoBasal = Double.Parse(reader["MetabolismoBasal"].ToString());
                    UsuarioCache.Peso = double.Parse(reader["Peso"].ToString());
                    UsuarioCache.Altura = double.Parse(reader["Altura"].ToString());


                    if (correo != UsuarioCache.Correo || contrasenna != UsuarioCache.Contrasenna)
                    {
                        throw new Exception("Email o contraseña incorrectos");
                    }
                    resultado = true;
                }
            }
            return resultado;
        }

        public List<Usuario> GetUsuarioByFiltro(string filtro)
        {
            DataSet ds = null;
            SqlCommand comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            List<Usuario> lista = new List<Usuario>();
            comando.CommandText = "usp_ObtenerUsuarioByFiltro";
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
                    Usuario user = new Usuario();
                    user.Id = dr["Id"].ToString();
                    user.Nombre = dr["Nombre"].ToString();
                    user.Apellidos = dr["Apellidos"].ToString();
                    user.Correo = dr["Correo"].ToString();
                    user.Correo = dr["Correo"].ToString();
                    user.Contrasenna = dr["password"].ToString();
                    user.FechaNacimiento = (DateTime)dr["FechaNacimiento"];
                    user.Telefono = (int)dr["Telefono"];
                    user.IdTipoUsuario = (int)dr["IdTipo"];
                    user.Imagen = (byte[])dr["Foto"];
                    user.IdGenero = (int)dr["IdGenero"];
                    user.IMC = (double)Convert.ToDouble(dr["IMC"]);
                    user.MetabolismoBasal = (double)Convert.ToDouble(dr["MetabolismoBasal"]);
                    user.Peso = (double)dr["Peso"];
                    user.Altura = double.Parse(dr["Altura"].ToString());

                    lista.Add(user);

                }

            }
            return lista;
        }

        public string ObtenerUsuarioIdByIdFac(int idFactura)
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "usp_UsuarioByFactura";
                comando.Parameters.AddWithValue("@IdFactura", idFactura);

                IDataReader reader = db.ExecuteReader(comando);

                while (reader.Read())
                {
                    string idUsuario = reader["Id"].ToString();


                    return idUsuario;
                }
            }

            return null;
        }

        public void InsertaIngresoEgreso()
        {
            using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "usp_INSERT_HistorialUsuario";
                comando.Parameters.AddWithValue("@IdUsuario", UsuarioCache.Id);
                comando.Parameters.AddWithValue("@FechaIngreso", UsuarioCache.FechaIngreso);
                comando.Parameters.AddWithValue("@FechaEgreso", UsuarioCache.FechaEgreso);


                db.ExecuteNonQuery(comando);
            }
        }
    }
}