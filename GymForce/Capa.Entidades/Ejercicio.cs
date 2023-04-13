using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Entidades
{
    public class Ejercicio
    {
       

        public int Id { get; set; }
        public int IdTipoEjercicio { get; set; }
        public int IdEntrenamiento { get; set; }
        public string Nombre { get; set; }
        public string  Descripcion{ get; set; }
        public TipoEjercicio _TipoEjercicio { get; set; }
        public Entrenamiento _Entrenamiento { get; set; }
        public byte[] Imagen{ get; set; }

        public double Peso { get; set; }
        public int TiempoDescanso{ get; set; }
         public int CantRepeticiones{ get; set; }
        public int Series { get; set; }




        public string EntrenamientoNombre
        {
            get
            {
                return _Entrenamiento.Nombre;
            }
        }
        public string TipoEjercicioNombre
        {
            get
            {
                return _TipoEjercicio.Nombre;
            }
        }
    }

}
