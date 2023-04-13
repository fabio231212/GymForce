using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Entidades.Cache
{
    public static class UsuarioCache
    {
        public static string Id { get; set; }
        public static string Nombre { get; set; }
        public static string Apellidos { get; set; }
        public static string Correo { get; set; }
        public static DateTime FechaNacimiento { get; set; }
        public static int Telefono { get; set; }
        public static TipoUsuario _TipoUsuario { get; set; }
        public static int IdTipoUsuario { get; set; }
        public static int IdGenero { get; set; }
        public static string Contrasenna { get; set; }
        public static byte[] Imagen { get; set; }
        public static double Peso { get; set; }
        public static double Altura { get; set; }
        public static double IMC { get; set; }
        public static double MetabolismoBasal { get; set; }
        public static DateTime FechaIngreso { get; set; }
        public static DateTime FechaEgreso { get; set; }
    }
}
