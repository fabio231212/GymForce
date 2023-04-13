using Capa.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Interfaces
{
    public interface IUsuarioLN
    {
        void Guardar(Usuario user);
        void Eliminar(string id);
        List<Usuario> ObtenerUsuarios();
        bool VerificarAcceso(string correo, string contrasenna);

        List<Usuario> GetUsuarioByFiltro(string filtro);

        string ObtenerUsuarioIdByIdFac(int idFactura);
        Usuario SeleccionarPorId(string id);

        void InsertaIngresoEgreso();



    }
}
