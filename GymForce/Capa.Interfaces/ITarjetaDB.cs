using capa.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Interfaces
{
    public interface ITarjetaDB
    {
        Tarjeta SeleccionarById(int id);
        List<Tarjeta> SeleccionarTodas();
    }
}
