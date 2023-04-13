using capa.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Interfaces
{
    public interface IFacturaLN
    {
        void Guardar(EncFactura encFactura);

        void Eliminar(int idFactura);

        List<EncFactura> SeleccionarTodas();

        EncFactura SeleccionarPorId(int idFactura);

        int GetNextNumeroFactura();

        int GetCurrentNumeroFactura();
        DateTime fechaProximoPagoById(string idUsuario);
    }
}
