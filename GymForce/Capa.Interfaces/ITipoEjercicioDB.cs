using Capa.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Interfaces
{
    public interface ITipoEjercicioDB
    {
        TipoEjercicio ObtenerPorId(int id);
        List<TipoEjercicio> ObtenerTiposEjercicios();
    }
}
