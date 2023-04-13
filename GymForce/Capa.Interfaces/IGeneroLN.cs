using capa.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Interfaces
{
    public interface IGeneroLN
    {
        List<Genero> ObtenerGenero();
        Genero ObtenerPorId(int id);
    }
}
