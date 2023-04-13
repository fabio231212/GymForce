using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Entidades
{
    public class Usuario
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Correo { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int Telefono { get; set; }
        public TipoUsuario _TipoUsuario { get; set; }
        public int IdTipoUsuario { get; set; }
        public int IdGenero { get; set; }
        public string Contrasenna { get; set; }
        public byte[] Imagen { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        public double IMC { get; set; }
        public double MetabolismoBasal { get; set; }

        public string TipoUsuarioNombre
        {
            get
            {
                return _TipoUsuario.Descripcion;
            }
        }
        public void CalculaIMC()
        {
            IMC = Peso / Math.Pow(Altura/100, 2);
        }
        public void CalculaMetabolismo()
        {
            //(10 x peso de Kg) +(6, 25 x altura en cm) – (5 x edad en años) +5
            if (IdGenero == 1)
            {
                MetabolismoBasal = (10 * Peso) + (6.25 * Altura) - (5 * (DateTime.Now.Year - FechaNacimiento.Year)) + 5;
            }
            else
            {
                //Mujeres TMB = (10 x peso en kg) +(6, 25 x altura en cm) – (5 x edad en años) – 161
                MetabolismoBasal = (10 * Peso) + (6.25 * Altura) - (5 * (DateTime.Now.Year - FechaNacimiento.Year)) -161;
            }
        }


    }
}
