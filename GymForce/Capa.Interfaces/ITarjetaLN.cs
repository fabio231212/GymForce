using capa.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Interfaces
{
    public interface ITarjetaLN
    {
       List<Tarjeta> SeleccionarTodas();
        Tarjeta SeleccionarById(int id);
    }
}
