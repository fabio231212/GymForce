using Capa.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Interfaces
{
    public interface IUsuarioDB
    {
        void Insertar(Usuario user);
        void Actualizar(Usuario user);
        void Eliminar(string id);
        List<Usuario> SeleccionarTodas();
        Usuario SeleccionarPorId(string id);
        bool VerificarLogin(string correo, string contrasenna);

        List<Usuario> GetUsuarioByFiltro(string filtro);

        string ObtenerUsuarioIdByIdFac(int idFactura);

        void InsertaIngresoEgreso();


    }
}
