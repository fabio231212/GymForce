using Capa.Datos;
using Capa.Entidades;
using Capa.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Logica.BLL
{
    public class UsuarioLN : IUsuarioLN
    {
        /// <summary>
        /// Método para eliminar los usuarios
        /// </summary>
        /// <param name="id"></param>
        public void Eliminar(string id)
        {
            IUsuarioDB datos = new UsuarioDB();
            if (datos.SeleccionarPorId(id) == null)
                throw new ApplicationException("El código no existe");

            datos.Eliminar(id);
        }

        /// <summary>
        /// Método que obtiene usuario por filtro
        /// </summary>
        /// <param name="filtro"></param>
        /// <returns></returns>
        public List<Usuario> GetUsuarioByFiltro(string filtro)
        {
            IUsuarioDB datos = new UsuarioDB();
            return datos.GetUsuarioByFiltro(filtro);
        }

        /// <summary>
        /// Método que guarda los usuarios
        /// </summary>
        /// <param name="user"></param>
        public void Guardar(Usuario user)
        {
            if (user == null)
                throw new ApplicationException("No existe ningún usuario");
            if (user.Nombre.Length == 0)
                throw new ApplicationException("El nombre es requerido");

            IUsuarioDB datos = new UsuarioDB();
            if (datos.SeleccionarPorId(user.Id) == null)
            {
                datos.Insertar(user);
            }
            else
            {
                datos.Actualizar(user);
            }
        }


        /// <summary>
        /// Método para guardar el historial del ingreso
        /// </summary>
        public void InsertaIngresoEgreso()
        {
            IUsuarioDB datos = new UsuarioDB();
            datos.InsertaIngresoEgreso();
        }


        /// <summary>
        /// Método que obtiene usuario by id factura
        /// </summary>
        /// <param name="idFactura"></param>
        /// <returns></returns>
        public string ObtenerUsuarioIdByIdFac(int idFactura)
        {
            IUsuarioDB datos = new UsuarioDB();
            return datos.ObtenerUsuarioIdByIdFac(idFactura);
        }

        /// <summary>
        /// Método que obtiene todos los usuarios
        /// </summary>
        /// <returns></returns>
        public List<Usuario> ObtenerUsuarios()
        {
            IUsuarioDB datos = new UsuarioDB();
            return datos.SeleccionarTodas();
        }

        /// <summary>
        /// Método que selecciona usuario por id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Usuario SeleccionarPorId(string id)
        {
            IUsuarioDB datos = new UsuarioDB();
            return datos.SeleccionarPorId(id);
        }
        /// <summary>
        /// Método para verificar el login
        /// </summary>
        /// <param name="correo"></param>
        /// <param name="contrasenna"></param>
        /// <returns></returns>
        public bool VerificarAcceso(string correo, string contrasenna)
        {
            IUsuarioDB datos = new UsuarioDB();
            return datos.VerificarLogin(correo, contrasenna);
        }
    }
}
