﻿using Capa.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Interfaces
{
    public interface ITipoUsuarioLN
    {
        TipoUsuario ObtenerPorId(int id);

        List<TipoUsuario> ObtenerTodos();
    }
}
